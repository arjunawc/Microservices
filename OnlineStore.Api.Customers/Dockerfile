#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["OnlineStore.Api.Customers/OnlineStore.Api.Customers.csproj", "OnlineStore.Api.Customers/"]
RUN dotnet restore "OnlineStore.Api.Customers/OnlineStore.Api.Customers.csproj"
COPY . .
WORKDIR "/src/OnlineStore.Api.Customers"
RUN dotnet build "OnlineStore.Api.Customers.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OnlineStore.Api.Customers.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OnlineStore.Api.Customers.dll"]
