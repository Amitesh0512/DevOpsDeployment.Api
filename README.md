# Production-Ready DevOps Deployment

Minimal API with Docker, GitHub Actions CI/CD, health checks, and environment configuration.

## Features

- Health checks (liveness, readiness)
- Multi-stage Dockerfile
- GitHub Actions: build, test, push image
- Environment config (appsettings per env)
- Structured logging

## Run

```bash
dotnet run
# or
docker build -t devops-api .
docker run -p 5000:8080 devops-api
```

## CI/CD

- `.github/workflows/ci.yml` — Build and test on PR/push
- `.github/workflows/cd.yml` — Build Docker image, push to registry (optional)

## Tech Stack

- .NET 8, ASP.NET Core
- Docker (multi-stage)
- GitHub Actions
- Health checks (AspNetCore.HealthChecks)
