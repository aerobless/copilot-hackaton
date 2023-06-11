# Use the aspnetcore 7.0 runtime image as the base image
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base

# Copy publish forler to image
COPY ./publish/ App/

# Run app
ENTRYPOINT ["dotnet", "App/copilot-hackaton.dll"]