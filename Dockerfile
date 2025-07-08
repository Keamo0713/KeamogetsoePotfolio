# Dockerfile located at KeamogetsoePotfolio/Dockerfile
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy solution file and all project files first to leverage build caching
COPY ["KeamogetsoePotfolio.sln", "."]
COPY ["YourProjectFolder/YourProject.csproj", "YourProjectFolder/"]
# If you have other library projects, include them too, e.g.:
# COPY ["YourProjectFolder/YourLibraryProject/YourLibraryProject.csproj", "YourProjectFolder/YourLibraryProject/"]

# Restore NuGet packages
RUN dotnet restore "YourProjectFolder/YourProject.csproj"

# Copy the rest of your application code (from the solution root)
COPY . .

# Change to the directory of your main project for building and publishing
WORKDIR "/src/YourProjectFolder"

# Publish the application
RUN dotnet publish "YourProject.csproj" -c Release -o /app/publish --no-self-contained --no-restore

# --- Runtime Image ---
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app

# Copy the published output from the build stage
COPY --from=build /app/publish .

# Configure port for Render
ENV ASPNETCORE_URLS=http://+:$PORT
ENV PORT 10000

EXPOSE 10000
ENTRYPOINT ["dotnet", "YourProject.dll"]
