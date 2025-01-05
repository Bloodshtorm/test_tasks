
import requests
API_KEY = "164ba2ac9bd64ece806122553250501"

def main():
    """
    Основная функция программы.
    """
    #print("Добро пожаловать в клиент погоды!")
    city=input("Введите ваш город: ")
    get_weather(city)


def get_weather(current_city):
    #print("получаем погоду")
    params = {
        "q": current_city,          # Название города
        "key": API_KEY,   # Ваш API-ключ
        "api": "no"
    }

    response = requests.    ("http://api.weatherapi.com/v1/current.json", params=params)
    #print(response.content)

    if response.status_code == 200:
        data = response.json()
        location = data.get("location", {})
        current = data.get("current", {})

        print(f"\nГород: {location.get('name', 'Неизвестно')}, {location.get('region', 'Неизвестно')}, {location.get('country', 'Неизвестно')}")
        print(f"Температура: {current.get('temp_c', 'Нет данных')}°C")
        print(f"Ощущается как: {current.get('feelslike_c', 'Нет данных')}°C")
        print(f"Влажность: {current.get('humidity', 'Нет данных')}%")
        print(f"Ветер: {current.get('wind_kph', 'Нет данных')} км/ч, направление {current.get('wind_dir', 'Нет данных')}")
    else:
        print(f"Ошибка {response.status_code}: {response.text}")
################################################################
if __name__ == "__main__":
    main()

