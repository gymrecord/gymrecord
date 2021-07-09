FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
COPY . ./app

WORKDIR /app/
RUN dotnet build -c Release -o output

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS runtime
COPY --from=build /app/output .
ENTRYPOINT ["dotnet", "GymRecord.dll"]