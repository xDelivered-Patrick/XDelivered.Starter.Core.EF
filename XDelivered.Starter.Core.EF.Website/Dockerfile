FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 3001
EXPOSE 44374

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY XDelivered.Starter.Core.EF.Website/XDelivered.Starter.Core.EF.Website.csproj XDelivered.Starter.Core.EF.Website/
RUN dotnet restore XDelivered.Starter.Core.EF.Website/XDelivered.Starter.Core.EF.Website.csproj
COPY . .
WORKDIR /src/XDelivered.Starter.Core.EF.Website
RUN dotnet build XDelivered.Starter.Core.EF.Website.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish XDelivered.Starter.Core.EF.Website.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "XDelivered.Starter.Core.EF.Website.dll"]
