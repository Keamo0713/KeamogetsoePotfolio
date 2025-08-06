<<<<<<< HEAD
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
=======
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

# Render's default port (comment moved to its own line for clarity)
ENV PORT 10000 

# Expose the port (informative for Docker, but Render handles port mapping)
EXPOSE 10000

# Define the entry point for your application
# This is the DLL that will be executed when the container starts
>>>>>>> 37db4e9c58dbff33493972da4b3efae6d2c82c11
ENTRYPOINT ["dotnet", "KeamogetsoePotfolio.dll"]
