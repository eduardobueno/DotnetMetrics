# DotnetMetrics
*José Eduardo Bueno de Camargo - Abril, 2023

## Sobre

Este projeto tem por objetivo servir como uma PoC (Prova de Conceito) para a implementação de coleta de métricas que poderão ser exportadas para o **Prometheus**. 

## Como executar o projeto

- Para criar a imagem do projeto que será utilizada para a criação do *Container* no Docker:

```
docker build -t <dockerhub username>/dotnetmetrics:latest .
```

- Para executar o projeto, basta rodar o Docker Compose, utilizando o seguinte comando (no diretório da aplicação):

```
docker compose up
```

*Este comando irá executar não só a aplicação, mas também o *Prometheus* como Containeres no Docker.*

**Importante!**

Não esqueça de substituir no arquivo *docker-compose.yaml* o nome da imagem do projeto, de acordo com o que você especificou no momento da criação dela.