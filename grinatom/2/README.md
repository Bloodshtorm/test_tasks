# Задания
#### 2. Перепишите Dockerfile
```
FROM ubuntu:20.04
COPY ./src /app
RUN apt-get update -y
RUN apt-get install -y nodejs
RUN npm install
ENTRYPOINT ["npm"]
CMD ["run", "prod"]
```

**Выполнено**