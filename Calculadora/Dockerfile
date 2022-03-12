FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["primeiro-repositorio-calculadora/Calculadora/Calculadora.csproj", "primeiro-repositorio-calculadora/Calculadora/"]
RUN dotnet restore "primeiro-repositorio-calculadora\Calculadora\Calculadora.csproj"
COPY . .
WORKDIR "/src/primeiro-repositorio-calculadora/Calculadora"
RUN dotnet build "Calculadora.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Calculadora.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Calculadora.dll"]
