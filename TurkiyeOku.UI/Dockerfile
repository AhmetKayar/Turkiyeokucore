FROM microsoft/aspnetcore:2.0-stretch AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0-stretch AS build
WORKDIR /src
COPY TurkiyeOku.UI/TurkiyeOku.UI.csproj TurkiyeOku.UI/
RUN dotnet restore "TurkiyeOku.UI/TurkiyeOku.UI.csproj"
COPY . .
WORKDIR "/src/TurkiyeOku.UI"
RUN dotnet build "TurkiyeOku.UI.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "TurkiyeOku.UI.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "TurkiyeOku.UI.dll"]
