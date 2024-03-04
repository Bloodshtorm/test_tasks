import requests
import csv
from datetime import datetime

# Список городов
cities = ['Самара', 'Казань']

# Получение API ключа (замените "YOUR_API_KEY" на ваш ключ)
# Мой работающий ключ -> "43d34fca-6a96-4c9b-9baf-f738909e114b"
api_key =  "YOUR_API_KEY" 

# Функция для получения прогноза погоды для заданного города на 7 дней
def get_weather_forecast(city):
    url = f"https://api.weather.yandex.ru/v2/forecast?city={city}&limit=3"
    headers = {"X-Yandex-API-Key": api_key}
    response = requests.get(url, headers=headers)
    if response.status_code == 200:
        return response.json()
    else:
        print(f"Failed to fetch weather forecast for {city}. Status code: {response.status_code}")
        return None

# Функция для записи данных в CSV файл
def write_to_csv(data, filename):
    with open(filename, mode='w', newline='', encoding='utf-8') as file:
        writer = csv.writer(file)
        writer.writerow(['city', 'date', 'hour', 'temperature_c', 'pressure_mm', 'is_rainy'])
        for row in data:
            writer.writerow(row)

# Функция для обработки прогноза погоды и формирования данных для CSV
def process_weather_forecast(city, forecast):
    processed_data = []
    for day in forecast['forecasts']:
        date = datetime.strptime(day['date'], "%Y-%m-%d")
        for hour_forecast in day['hours']:
            hour = hour_forecast['hour']
            temperature_c = hour_forecast['temp']
            pressure_mm = hour_forecast['pressure_mm']
            is_rainy = 1 if hour_forecast['prec_mm'] > 0 else 0
            processed_data.append([city, date.strftime('%d.%m.%Y'), hour, temperature_c, pressure_mm, is_rainy])
    return processed_data

# Получение прогноза погоды на 3 дня для всех городов
all_forecasts = []
for city in cities:
    weather_forecast = get_weather_forecast(city)
    if weather_forecast:
        processed_forecast = process_weather_forecast(city, weather_forecast)
        all_forecasts.extend(processed_forecast)

# Удаление пустых значений за день
all_forecasts = [forecast for forecast in all_forecasts if forecast[3] is not None]

# Запись данных в CSV файл
write_to_csv(all_forecasts, 'weather_forecast.csv')



