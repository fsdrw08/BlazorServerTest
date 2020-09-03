# https://hub.docker.com/_/microsoft-dotnet-core
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /Workspace

# copy csproj and restore as distinct layers
COPY BlazorServer/*.csproj ./BlazorServer/
WORKDIR /Workspace/BlazorServer
RUN dotnet restore

# copy everything else and build app
WORKDIR /Workspace
COPY BlazorServer/. ./BlazorServer/
WORKDIR /Workspace/BlazorServer
RUN dotnet publish -c Release -o /app --no-restore

# final stage/image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT ["dotnet", "BlazorServer.dll"]