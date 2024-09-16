#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.


FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
ARG NUGET_PASS
ARG STRING111

WORKDIR /src
COPY ["NuGet.config", "."]
COPY ["WebApi/WebApi.csproj", "WebApi/"]
COPY ["DataAccess/DataAccess.csproj", "DataAccess/"]
COPY ["Domain/Domain.csproj", "Domain/"]
COPY ["Models/Models.csproj", "Models/"]
COPY ["Services/Services.csproj", "Services/"]

RUN echo $NUGET_PASS
RUN echo $STRING111
RUN echo "1111111111"
RUN dotnet nuget add source "https://nuget.pkg.github.com/Yuman-net/index.json" --name "Yuman-net" --username and.nik.dev@gmail.com --password $NUGET_PASS --store-password-in-clear-text
RUN dotnet restore "./WebApi/WebApi.csproj"
COPY . .
WORKDIR "/src/WebApi"
RUN dotnet build "./WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebApi.dll"]
