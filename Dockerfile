# Use the official .NET SDK image to build the application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy the solution file and all project files first to leverage build caching
# This assumes your solution file is KeamogetsoePotfolio.sln
# And your main project folder and csproj are also named KeamogetsoePotfolio
COPY ["KeamogetsoePotfolio.sln", "."]
COPY ["KeamogetsoePotfolio/KeamogetsoePotfolio.csproj", "KeamogetsoePotfolio/"]
# If you have any other projects in your solution (e.g., a Library project),
# add their .csproj files here. For example:
# COPY ["KeamogetsoePotfolio.Infrastructure/KeamogetsoePotfolio.Infrastructure.csproj", "KeamogetsoePotfolio.Infrastructure/"]

# Restore NuGet packages for the main project
# This will also restore packages for any referenced projects defined in the .sln
RUN dotnet restore "KeamogetsoePotfolio/KeamogetsoePotfolio.csproj"

# Copy the rest of your application code (from the solution root into /src)
COPY . .

# Change to the directory of your main project for building and publishing
WORKDIR "/src/KeamogetsoePotfolio"

# Publish the application
# -c Release: Build in Release configuration
# -o /app/publish: Output compiled app to /app/publish
# --no-self-contained: Create a framework-dependent executable (smaller size)
# --no-restore: Don't restore packages again, they were restored above
RUN dotnet publish "KeamogetsoePotfolio.csproj" -c Release -o /app/publish --no-self-contained --no-restore

# --- Runtime Image ---
# Use the official .NET ASP.NET Core Runtime image for the final application
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app

# Copy the published output from the build stage
# This copies everything needed to run your app into the final, smaller image
COPY --from=build /app/publish .

# Set the port Render expects and ensure your .NET app listens on it
ENV ASPNETCORE_URLS=http://+:$PORT
ENV PORT 10000 # Render's default port

# Expose the port (informative for Docker, but Render handles port mapping)
EXPOSE 10000

# Define the entry point for your application
# This is the DLL that will be executed when the container starts
ENTRYPOINT ["dotnet", "KeamogetsoePotfolio.dll"]
