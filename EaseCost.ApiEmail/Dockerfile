FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["EaseCost.ApiEmail/EaseCost.ApiEmail.csproj", "EaseCost.ApiEmail/"]
RUN dotnet restore "EaseCost.ApiEmail/EaseCost.ApiEmail.csproj"
COPY . .
WORKDIR "/src/EaseCost.ApiEmail"
RUN dotnet build "EaseCost.ApiEmail.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "EaseCost.ApiEmail.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "EaseCost.ApiEmail.dll"]