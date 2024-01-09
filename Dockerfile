# Set the base image to .NET 6 SDK
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

# Set the working directory to /app
WORKDIR /app

# Copy the project file(s) and restore dependencies
COPY JellyBellyWikiApi.Solution/*.csproj ./JellyBellyWikiApi.Solution/
RUN dotnet restore JellyBellyWikiApi.Solution/*.csproj

# Copy the remaining source code
COPY JellyBellyWikiApi.Solution/ ./JellyBellyWikiApi.Solution/

# Build the application
RUN dotnet publish JellyBellyWikiApi.Solution/ -c Release -o out

# Create the runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "JellyBellyWikiApi.dll"]