# Stage 1: Build the application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

# Copy the .sln file if you have one at the solution root
# Adjust path if your .sln is not at the repo root
# For a single project repo where .csproj is at the root, you might skip this line.
COPY KeamogetsoePotfolio.sln . # Make sure this matches your actual solution file name

# Copy the .csproj files and restore dependencies
# This assumes your main project is 'KeamogetsoePotfolio' within a folder of the same name.
# Adjust these paths if your project structure is different (e.g., .csproj directly at repo root)
COPY KeamogetsoePotfolio/*.csproj ./KeamogetsoePotfolio/
RUN dotnet restore KeamogetsoePotfolio/KeamogetsoePotfolio.csproj

# Copy the rest of the source code
COPY . .

# Publish the application
# Adjust 'KeamogetsoePotfolio.csproj' if your project file has a different name
# Ensure the -o /app/publish directory matches the WORKDIR in the final stage
WORKDIR /app/KeamogetsoePotfolio # This should be the directory containing your main .csproj
RUN dotnet publish -c Release -o /app/publish --no-restore

# Stage 2: Create the final runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

# Copy the published output from the build stage
COPY --from=build-env /app/publish .

# Expose the port your application listens on (default for ASP.NET Core is 80)
EXPOSE 80

# Define the entry point for the container
# This assumes your main assembly (DLL) name is 'KeamogetsoePotfolio.dll'
ENTRYPOINT ["dotnet", "KeamogetsoePotfolio.dll"]
