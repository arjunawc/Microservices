#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["OnlineStore.Api.Products/OnlineStore.Api.Products.csproj", "OnlineStore.Api.Products/"]
RUN dotnet restore "OnlineStore.Api.Products/OnlineStore.Api.Products.csproj"
COPY . .
WORKDIR "/src/OnlineStore.Api.Products"
RUN dotnet build "OnlineStore.Api.Products.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OnlineStore.Api.Products.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OnlineStore.Api.Products.dll"]
