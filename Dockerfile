FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["./DotnetMetrics.csproj", "./"]
RUN dotnet restore "./DotnetMetrics.csproj"
COPY . .
WORKDIR "./"
RUN dotnet build "DotnetMetrics.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DotnetMetrics.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DotnetMetrics.dll"]