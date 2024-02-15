FROM ubuntu:20.04

# Обновление пакетного менеджера и установка Node.js и npm, плюс можно добавить что нибудь полезное типо curl
RUN apt-get update -y \
    && apt-get install -y nodejs npm curl \
    && rm -rf /var/lib/apt/lists/*

# Установка зависимостей npm
WORKDIR /app
COPY ./src/package.json ./src/package-lock.json /app/
RUN npm install

# Копирование исходного кода
COPY ./src /app

# Установка точки входа и аргументов по умолчанию
ENTRYPOINT ["npm"]
CMD ["run", "prod"]