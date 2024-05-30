import org.apache.spark.sql.expressions.Window
import org.apache.spark.sql.functions.{avg, concat, lit, max, min, monotonically_increasing_id, round}
import org.apache.spark.sql.{SparkSession, functions => func}

object Main {
  def main(args: Array[String]): Unit = {

    val spark = SparkSession
      .builder()
      .appName("Spark")
      .master("local[*]")
      .getOrCreate()

    import spark.implicits._

    //person
    val id = List(1, 2, 3, 4, 5)
    val firstNames = List("Alex", "Dima", "Serega", "Alexandr", "Oleg")
    val lastNames = List("ewrqw", "asd", "ewrqw", "asd", "ewrqw")
    val ages = List(25, 30, 35, 45, 60)

    //salary
    val personId = List(1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5)
    val month = List(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12,
      1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 1, 2, 3, 4, 5,
      6, 7, 8, 9, 10, 11, 12)
    val salary = List(130000, 150120, 120640, 138580, 142000, 175000, 165860,
      170000, 185000, 163000, 190210, 150240, 130500, 150150, 120010, 138650,
      142000, 175000, 165000, 170320, 185340, 163480, 190800, 150100, 130450,
      150000, 120000, 138000, 142430, 175540, 165860, 170980, 185200, 163350,
      190000, 150000, 130000, 150650, 120760, 138320, 142670, 175300, 165150,
      170000, 185000, 163000, 190760, 150230, 130120, 150450, 120400, 138250,
      142000, 175000, 165000, 170130, 185460, 163530, 190130, 150500)

    val personMergedDf = id.toDF("id")
      .withColumn("index", monotonically_increasing_id())
      .join(firstNames.toDF("firstName").withColumn("index", monotonically_increasing_id()), Seq("index"))
      .join(lastNames.toDF("LastName").withColumn("index", monotonically_increasing_id()), Seq("index"))
      .join(ages.toDF("age").withColumn("index", monotonically_increasing_id()), Seq("index"))
      .drop("index")

    val salaryMergedDf = personId.toDF("id")
      .withColumn("index", monotonically_increasing_id())
      .join(month.toDF("month").withColumn("index", monotonically_increasing_id()), Seq("index"))
      .join(salary.toDF("salary").withColumn("index", monotonically_increasing_id()), Seq("index"))
      .drop("index")

    val personSalaryDF = salaryMergedDf
      .join(personMergedDf, salaryMergedDf("id") === personMergedDf("id"), "inner")

    // месяцы когда зп выше средней
    val salaryAvgUp = personSalaryDF
      .withColumn("avg_sal", round(avg("salary") over Window.partitionBy("firstName"), 2))
      .select("firstName", "LastName", "age", "month")
      .where("salary > avg_sal")
      .orderBy("avg_sal")

    // группировка сотрудников на 3 группы и вывод статистики по з/п
    val groupPersonDF = personSalaryDF
      .withColumn("range", concat($"age" - ($"age" % 5), lit(" - "), ($"age" - ($"age" % 5)) + 5))
      .withColumn("Avg", round(avg("salary") over Window.partitionBy("range"), 2))
      .withColumn("Min", round(min("salary") over Window.partitionBy("range"), 2))
      .withColumn("Max", round(max("salary") over Window.partitionBy("range"), 2))
      .select("range", "Avg", "Min", "Max")
      .orderBy("Avg")
      .distinct()

    groupPersonDF.write.json("src/main/resources/df_json1.json")
    val df = spark.read.json("src/main/resources/df_json1.json")
    //df.show()

    val cols = Seq("Min", "Max", "Avg")

    val unpivot = df.select(
      $"range",
      func.explode(
        func.array(
          cols.map(
            col => func.struct(
              func.lit(col).alias("agg_type"),
              func.col(col).alias("salary_value")
            )
          ): _*
        )
      ).alias("v")
    ).selectExpr("range", "v.*")

   // unpivot.show()
    spark.stop()
    }
}