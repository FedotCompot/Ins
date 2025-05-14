FROM mcr.microsoft.com/dotnet/sdk:9.0-alpine AS builder

WORKDIR /app

COPY DbIns/*.csproj DbIns/
COPY Ins/*.csproj Ins/

RUN dotnet restore Ins

COPY . .

RUN dotnet publish Ins -c Release -o out --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:9.0-alpine

WORKDIR /app
COPY --from=builder /app/out .
EXPOSE 80

CMD [ "dotnet", "Ins.dll" ]