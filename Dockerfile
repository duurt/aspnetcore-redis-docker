FROM microsoft/dotnet:sdk AS build-env
WORKDIR /app

# Copy everything
COPY . ./

# Build
RUN dotnet publish redisTryout.csproj -c Release -o /app/out

# Build runtime image
FROM microsoft/dotnet:aspnetcore-runtime
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "redisTryout.dll"]
