# Simple C# Web API with GitHub CI/CD

This repo contains a minimal .NET 7 Web API project with a full GitHub Actions pipeline.

### ✅ Features
- Build + Unit Test automation
- Security formatting check
- Environment-specific deploy steps
- Auto-deploy to Dev → Manual to Prod

### 🚀 To Use
1. Fork this repo
2. Add GitHub Environments: `Development`, `QA`, `Production`
3. Optional: Add environment secrets for secure deploy
4. Push changes to trigger pipeline

### 🔐 Security
- Enforce HTTPS redirection (via Kestrel config)
- Apply TLS/SSL in hosting infra
- Optional: Add `OWASP Dependency Check` or `dotnet security`
