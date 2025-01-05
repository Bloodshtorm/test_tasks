
import requests
API_KEY = "164ba2ac9bd64ece806122553250501"

def main():
    """
    Основная функция программы.
    """
    print("Добро пожаловать в клиент погоды!")
    get_weather()


def get_weather():
    print("получаем погоду")
    params = {
        "q": "Samara",          # Название города
        "key": API_KEY,   # Ваш API-ключ
        "api": "no"
    }

    response = requests.get("http://api.weatherapi.com/v1/current.json", params=params)
    print(response.content)

    if response.status_code == 200:
        data = response.json()
        print(f"Город: {data['location.name']}")
        #print(f"Температура: {data['main']['temp']}°C")
        #print(f"Погода: {data['weather'][0]['description']}")
    else:
        print(f"Ошибка {response.status_code}: {response.text}")
################################################################
if __name__ == "__main__":
    main()

