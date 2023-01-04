# Wordpress on .NET with OpenTelemetry and Honeycomb

This repository shows how to use Wordpress on .NET (using [PeachPie](https://www.peachpie.io/) to compile the PHP wordpress site into .NET) and add in OpenTelemetry sending the spans to Honeycomb.

This is a barebones implementation, not guaranteed to do much at all.

## Setup

Clone the repo

Setup a MySQL instance locally

```bash
docker run -e MYSQL_ROOT_PASSWORD=password -e MYSQL_DATABASE=wordpress -p 3306:3306 -d mysql
```

Add your Honeycomb API key to `appsettings.Development.json`

```bash
dotnet run
```

## Notes

PeachPie's MySQL implementation using MySQLConnector instead of MySQL.Data, so the OpenTelemetry Package isn't of use. MySQLConnector does have Activity Instrumentation though is under the `ActivitySource` named `MySqlConnector`. [https://mysqlconnector.net/tutorials/tracing/](https://mysqlconnector.net/tutorials/tracing/)
