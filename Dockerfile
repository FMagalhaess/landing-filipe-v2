# 1) Imagem de runtime
FROM mcr.microsoft.com/dotnet/aspnet:6.0   AS base
WORKDIR /app
EXPOSE 80

# 2) Imagem de build
FROM mcr.microsoft.com/dotnet/sdk:6.0     AS build
WORKDIR /src

# 2.1) Copia só o .csproj e restaura
COPY src/src.csproj ./
RUN dotnet restore src.csproj

# 2.2) Copia tudo o mais e publica
COPY src/. ./
RUN dotnet publish src.csproj -c Release -o /app/publish

# 3) Imagem final
FROM base                               AS final
WORKDIR /app
COPY --from=build /app/publish .  
ENTRYPOINT ["dotnet", "src.dll"]
