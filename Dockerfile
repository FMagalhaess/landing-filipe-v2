# 1) Runtime
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

# 2) Build
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

# 2.1) Copia csproj e restaura
COPY src/src.csproj ./
RUN dotnet restore src.csproj

# 2.2) Copia tudo e publica
COPY src/. ./
RUN dotnet publish src.csproj -c Release -o /app/publish

# 3) Final
FROM base AS final
WORKDIR /app

# Certifique-se de copiar da pasta /app/publish do estágio de build
COPY --from=build /app/publish .  

ENTRYPOINT ["dotnet", "src.dll"]
