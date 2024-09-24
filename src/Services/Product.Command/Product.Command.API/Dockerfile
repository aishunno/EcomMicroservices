# Comment pointing to a URL that explains how to customize the debug container in Visual Studio.
# See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# Use the official .NET 8.0 runtime image as the base for the final container.
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base

# Switch to the 'app' user for running the application with limited privileges for security reasons.
USER app

# Set the working directory inside the container to /app.
WORKDIR /app

# Expose ports 8080 and 8081, which will be used for HTTP traffic.
EXPOSE 8080
EXPOSE 8081

# Use the official .NET 8.0 SDK image for the build stage.
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Declare a build argument for setting the build configuration (default is Release).
ARG BUILD_CONFIGURATION=Release

# Set the working directory to /src for the build process.
WORKDIR /src

# Copy the Product.Command.API project file into the container, preserving the folder structure.
COPY ["Services/Product.Command/Product.Command.API/Product.Command.API.csproj", "Services/Product.Command/Product.Command.API/"]

# Restore dependencies defined in the .csproj file.
RUN dotnet restore "./Services/Product.Command/Product.Command.API/Product.Command.API.csproj"

# Copy all source code into the container.
COPY . .

# Set the working directory to the location of the Product.Command.API project.
WORKDIR "/src/Services/Product.Command/Product.Command.API"

# Build the project using the specified build configuration (Release by default) and output the build files to /app/build.
RUN dotnet build "./Product.Command.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Define a separate stage for publishing the application.
FROM build AS publish

# Reuse the build configuration argument.
ARG BUILD_CONFIGURATION=Release

# Publish the application to /app/publish without the app host, making it more lightweight.
RUN dotnet publish "./Product.Command.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Start from the base image defined earlier, which contains the runtime environment.
FROM base AS final

# Set the working directory to /app in the final container.
WORKDIR /app

# Copy the published files from the publish stage into the final container.
COPY --from=publish /app/publish .

# Define the entry point to run the application using the .NET runtime.
ENTRYPOINT ["dotnet", "Product.Command.API.dll"]
