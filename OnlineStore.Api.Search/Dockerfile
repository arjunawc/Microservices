#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["OnlineStore.Api.Search/OnlineStore.Api.Search.csproj", "OnlineStore.Api.Search/"]
RUN dotnet restore "OnlineStore.Api.Search/OnlineStore.Api.Search.csproj"
COPY . .
WORKDIR "/src/OnlineStore.Api.Search"
RUN dotnet build "OnlineStore.Api.Search.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OnlineStore.Api.Search.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OnlineStore.Api.Search.dll"]
