FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["Demo.WebAPI/Demo.WebAPI.csproj", "Demo.WebAPI/"]
COPY ["Demo.ConsoleLib/Demo.ConsoleLib.csproj", "Demo.ConsoleLib/"]
COPY ["Demo.Interfaces/Demo.Interfaces.csproj", "Demo.Interfaces/"]
COPY ["Demo.SocialLib/Demo.SocialLib.csproj", "Demo.SocialLib/"]
RUN dotnet restore "Demo.WebAPI/Demo.WebAPI.csproj"
COPY . .
WORKDIR "/src/Demo.WebAPI"
RUN dotnet build "Demo.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Demo.WebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Demo.WebAPI.dll"]