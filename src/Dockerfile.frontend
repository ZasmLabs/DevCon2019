FROM mcr.microsoft.com/dotnet/core/runtime:3.0-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["Demo.ConsoleApp/Demo.ConsoleApp.csproj", "Demo.ConsoleApp/"]
COPY ["Demo.Services/Demo.Services.csproj", "Demo.Services/"]
RUN dotnet restore "Demo.ConsoleApp/Demo.ConsoleApp.csproj"
COPY . .
WORKDIR "/src/Demo.ConsoleApp"
RUN dotnet build "Demo.ConsoleApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Demo.ConsoleApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Demo.ConsoleApp.dll"]