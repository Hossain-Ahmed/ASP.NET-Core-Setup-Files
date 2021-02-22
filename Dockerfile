FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["Demo.Web/*.csproj", "Demo.Web/"]
COPY ["Demo.DataAccessLayer/*.csproj", "Demo.DataAccessLayer/"]
COPY ["Demo.Foundation/*.csproj", "Demo.Foundation/"]
COPY ["Demo.Membership/*.csproj", "Demo.Membership/"]
RUN dotnet restore "Demo.Web/Demo.Web.csproj"
COPY . .
WORKDIR "/src/Demo.Web"
RUN dotnet build "Demo.Web.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Demo.Web.csproj" -c Release -o /app

FROM build AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Demo.Web.dll"]