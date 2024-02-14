FROM ubuntu:20.04

# Установка Node.js
RUN apt-get update -y && \
    apt-get install -y nodejs

# Копирование исходного кода приложения
COPY ./src /app

# Установка зависимостей
WORKDIR /app
RUN npm install

# Запуск приложения
ENTRYPOINT ["npm"]
CMD ["run", "prod"]