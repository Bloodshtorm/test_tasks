#!/bin/bash
#Это реально работающий скрипт.
echo Устанавливаем URL страницы для проверки
URL="https://hackware.ru/?p=5996"
echo URL=$URL

echo Используем curl для загрузки содержимого страницы
# -s: Тихий режим, чтобы не выводить лишний текст
# -f: Если сервер возвращает код ошибки, curl завершает работу с ненулевым статусом
# -L: Перенаправлять, если страница перенаправляется
# -m: Максимальное время ожидания загрузки страницы
# -k: Пропускать проверку сертификата SSL (для упрощения)
# -o: Сохранять вывод в файл
CURL_OUTPUT=$(curl -s -f -L -m 10 -k -o - "$URL") 

#Просто прикопаем результат, можно закоммитить
echo $CURL_OUTPUT > result.txt

TEXT="Операторы"
echo "TEXT="$TEXT

echo Проверяем, содержит ли вывод текст \"$TEXT\"
if [[ $CURL_OUTPUT =~ "$TEXT" ]]; then
    echo "Текст '$TEXT' найден на странице $URL"
    exit 0
else
    echo "Ошибка: Текст '$TEXT' не найден на странице $URL"
    exit 1
fi

echo А вообще как задание, странное, его бы доработь до нормального вида.
echo Что бы страницу там можно было вбить любую. Да и текст поиска.
echo Моё личное мнение, хороший скрипт, тот который легко читать и менять, но менять не прийдётся никогда.