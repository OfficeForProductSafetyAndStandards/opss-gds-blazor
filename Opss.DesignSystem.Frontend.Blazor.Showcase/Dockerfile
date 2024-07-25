#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Directory.build.props", "."]
COPY ["Opss.DesignSystem.Frontend.Blazor.Showcase/Opss.DesignSystem.Frontend.Blazor.Showcase.csproj", "Opss.DesignSystem.Frontend.Blazor.Showcase/"]
COPY ["Opss.DesignSystem.Frontend.Blazor.Components/Opss.DesignSystem.Frontend.Blazor.Components.csproj", "Opss.DesignSystem.Frontend.Blazor.Components/"]
RUN dotnet restore "./Opss.DesignSystem.Frontend.Blazor.Showcase/Opss.DesignSystem.Frontend.Blazor.Showcase.csproj"
COPY . .
WORKDIR "/src/Opss.DesignSystem.Frontend.Blazor.Showcase"
RUN dotnet build "./Opss.DesignSystem.Frontend.Blazor.Showcase.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Opss.DesignSystem.Frontend.Blazor.Showcase.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Opss.DesignSystem.Frontend.Blazor.Showcase.dll"]