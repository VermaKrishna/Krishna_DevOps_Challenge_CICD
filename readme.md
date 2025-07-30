# Simple C# Web API with GitHub CI/CD

This repo contains a minimal .NET 7 Web API project with a full GitHub Actions pipeline.

#Branching Strategy:

<img width="371" height="220" alt="image" src="https://github.com/user-attachments/assets/1b563dc6-4608-465d-97b0-4344e3089354" />


Details:
1. Weekly we will create a release branch from the Main
2. If any regression then we will fix in the Main first and then cherry pick the commit to Release branch
3. We can have a process called ASKMODE for the pushing new changes to release branch
4. QA and Prod will only allow the Main branch
5. We have configured the Environmnets in GitHub for approvals before each stage kicks in .
6. For Hotfix, we will create a branch out of the Release branch and then cherry pick the change to Main branch to avoid merge regression 


### ✅ Features
- Build + Unit Test automation
- Security formatting check
- Environment-specific deploy steps
- Auto-deploy to Dev → Manual to Prod

### 🚀 To Use
1. Fork this repo
2. Add GitHub Environments: `Dev`, `QA`, `Prod`
3. Optional: Add environment secrets for secure deploy
4. Push changes to trigger pipeline


