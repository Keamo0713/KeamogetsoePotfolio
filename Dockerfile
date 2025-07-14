# Stage 1: Build the application
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build-env # Using .NET 9.0 SDK

# Set the working directory inside the container
WORKDIR /app

# Copy the .csproj file and restore dependencies
# This assumes KeamogetsoePotfolio.csproj is directly in the /app directory
COPY KeamogetsoePotfolio.csproj ./
RUN dotnet restore

# Copy the rest of the application code
COPY . .

# Publish the application for production
# -c Release: Build in Release configuration
# -o /app/publish: Output to /app/publish directory
# --no-self-contained: Create a framework-dependent executable (smaller size)
# --no-restore: Don't restore packages again, they were restored above
RUN dotnet publish "KeamogetsoePotfolio.csproj" -c Release -o /app/publish --no-self-contained --no-restore

# Stage 2: Create the final runtime image
FROM mcr.microsoft.com/dotnet/aspnet:9.0 # Using .NET 9.0 ASP.NET runtime
WORKDIR /app

# Copy the published output from the build stage
COPY --from=build-env /app/publish .

# Expose the port your application listens on (Render's default for web services is 8080)
EXPOSE 8080

# Set the ASP.NET Core environment to Production
ENV ASPNETCORE_ENVIRONMENT=Production

# Define the entry point for the container
# This assumes your main compiled assembly (DLL) name is 'KeamogetsoePotfolio.dll'
ENTRYPOINT ["dotnet", "KeamogetsoePotfolio.dll"]
