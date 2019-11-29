
FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 5555

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY PlaylistAPI/PlaylistAPI.csproj PlaylistAPI/
RUN dotnet restore PlaylistAPI/PlaylistAPI.csproj
COPY . .
WORKDIR /src/PlaylistAPI
RUN dotnet build PlaylistAPI.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish PlaylistAPI.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "PlaylistAPI.dll"]
