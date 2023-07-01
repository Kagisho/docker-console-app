FROM mcr.microsoft.com/dotnet/sdk:7.0 as builder

WORKDIR /src
COPY docker-console-app.csproj ./docker-console-app/
RUN dotnet restore "docker-console-app/docker-console-app.csproj"

WORKDIR /docker-console-app
COPY . .
RUN dotnet publish -c Release -o /out docker-console-app.csproj

FROM mcr.microsoft.com/dotnet/runtime:7.0
WORKDIR /app
COPY --from=builder /out/ .
ENTRYPOINT ["dotnet", "docker-console-app.dll"]