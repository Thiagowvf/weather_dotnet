#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["weather_dotnet/weather_dotnet.csproj", "weather_dotnet/"]
RUN dotnet restore "weather_dotnet/weather_dotnet.csproj"
COPY . .
WORKDIR "/src/weather_dotnet"
RUN dotnet build "weather_dotnet.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "weather_dotnet.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "weather_dotnet.dll"]