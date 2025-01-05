import requests
import psycopg2
from datetime import datetime

API_KEY = "164ba2ac9bd64ece806122553250501"

# Установим параметры для подключения к PostgreSQL
DB_HOST = "192.168.0.2"
DB_PORT = "5432"
DB_NAME = "weather"
DB_USER = "bs"
DB_PASSWORD = "1234"

def main():
    """
    Основная функция программы.
    """
    city = input("Введите ваш город: ")
    weather_data = get_weather(city)

    if weather_data:
        save_to_db(weather_data)


def get_weather(current_city):
    """
    Получаем данные о погоде для заданного города.
    """
    params = {
        "q": current_city,          # Название города
        "key": API_KEY,             # Ваш API-ключ
        "api": "no"
    }
    response = requests.get("http://api.weatherapi.com/v1/current.json", params=params)

    if response.status_code == 200:
        data = response.json()
        location = data.get("location", {})
        current = data.get("current", {})

        weather_data = {
            "city": location.get('name', 'Неизвестно'),
            "region": location.get('region', 'Неизвестно'),
            "country": location.get('country', 'Неизвестно'),
            "temp_c": current.get('temp_c', 'Нет данных'),
            "feelslike_c": current.get('feelslike_c', 'Нет данных'),
            "humidity": current.get('humidity', 'Нет данных'),
            "wind_kph": current.get('wind_kph', 'Нет данных'),
            "wind_dir": current.get('wind_dir', 'Нет данных'),
            "hire_date": datetime.now().strftime("%Y-%m-%d %H:%M:%S")  # Текущее время для записи
        }
        print(f"\nГород: {location.get('name', 'Неизвестно')}, {location.get('region', 'Неизвестно')}, {location.get('country', 'Неизвестно')}")
        print(f"Температура: {current.get('temp_c', 'Нет данных')}°C")
        print(f"Ощущается как: {current.get('feelslike_c', 'Нет данных')}°C")
        print(f"Влажность: {current.get('humidity', 'Нет данных')}%")
        print(f"Ветер: {current.get('wind_kph', 'Нет данных')} км/ч, направление {current.get('wind_dir', 'Нет данных')}")


        return weather_data
    else:
        print(f"Ошибка {response.status_code}: {response.text}")
        return None


def save_to_db(weather_data):
    """
    Сохраняем данные о погоде в базе данных PostgreSQL.
    """
    try:
        # Подключаемся к базе данных
        conn = psycopg2.connect(
            host=DB_HOST,
            port=DB_PORT,
            dbname=DB_NAME,
            user=DB_USER,
            password=DB_PASSWORD
        )
        cursor = conn.cursor()

        # Запрос для вставки данных
        insert_query = """
        INSERT INTO weather_api (City, temp_c, feelslike_c, humidity, wind_kph, hire_date)
        VALUES (%s, %s, %s, %s, %s, %s)
        """
        data = (
            weather_data["city"],
            weather_data["temp_c"],
            weather_data["feelslike_c"],
            weather_data["humidity"],
            weather_data["wind_kph"],
            weather_data["hire_date"]
        )

        # Выполняем вставку
        cursor.execute(insert_query, data)
        conn.commit()

        print(f"Данные о погоде для города {weather_data['city']} успешно сохранены в базу данных.")

    except Exception as e:
        print(f"Ошибка при сохранении в базу данных: {e}")

    finally:
        # Закрываем соединение
        if conn:
            cursor.close()
            conn.close()


if __name__ == "__main__":
    main()

