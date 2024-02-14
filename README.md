# Задания
## 1. Напишите Systemd unit, который будет обеспечивать запуск сервера Prometheus, поддерживать работу процесса и перезапускать его в случае выхода из строя. Также необходимо предусмотреть в этом unit возможность перезагрузки конфигурации сервиса без его рестарта. 

## 2. Перепишите Dockerfile
```
FROM ubuntu:20.04
COPY ./src /app
RUN apt-get update -y
RUN apt-get install -y nodejs
RUN npm install
ENTRYPOINT ["npm"]
CMD ["run", "prod"]
```

## 3. Напишите простой ansible-скрипт по развороту Prometheus сервера с БД postgres на debian 11 c комментариями для выбранных шагов

## 4. Напишите bash-скрипт с обработкой статусов и ошибок, который проверить, что на странице https://it.is.mysite.ru есть текст "Про важное". Прокомментировать команды скрипта.

## При реализации пайплайна Jenkins с Ansible Playbook необходимо реализовать логику так, чтобы Jenkins pipeline и Ansible Playbook по отдельности не могли иметь полного набора информации для получения секрета из Vault, но при запуске плейбука в Jenkins, плейбук может получить секрет хранящийся в Vault.