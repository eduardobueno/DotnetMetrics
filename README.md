# DotnetMetrics
*José Eduardo Bueno de Camargo - Abril, 2023*

## Sobre

Este projeto tem por objetivo servir como uma PoC (Prova de Conceito) para a implementação de coleta de métricas da aplicação, que poderão ser exportadas para o [**Prometheus**](https://prometheus.io/) e acompanhadas através do [**Grafana**](https://grafana.com/). 

## Como executar o projeto

- Para criar a imagem do projeto que será utilizada para a criação do container no **Docker**:

```
docker build -t <dockerhub username>/dotnetmetrics:latest .
```

- Para executar o projeto, basta rodar o **Docker Compose**, utilizando o seguinte comando (no diretório da aplicação):

```
docker compose up
```

*Este comando irá executar não só a aplicação, mas também o Prometheus e o Grafana como containeres no Docker.*

>**Importante!**
>Não esqueça de substituir no arquivo *docker-compose.yaml* o nome da imagem do projeto, de acordo com o que você especificou no momento da criação dela.

### Informações adicionais

* A URL para acessar o endpoint da API no container do Docker é **http://localhost:8080/weatherforecast**;

* A URL para acessar o *Prometheus* é **http://localhost:9090**;

* A URL para acessar o *Grafana*  é **http://localhost:3000**;

* Você pode criar seus próprios Dashboards no *Grafana*, no entanto, é possível importar alguns já prontos, como o *prometheus-net* e o *ASP.NET Core - controller summary (Prometheus)*. Os códigos para importação de cada um são, respectivamente, *10427* e *10915*.