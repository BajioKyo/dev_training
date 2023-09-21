# Install .Net 7
## For Ubuntu:
1. Register the microsoft package repo:
```bash
# Get Ubuntu version
declare repo_version=$(if command -v lsb_release &> /dev/null; then lsb_release -r -s; else grep -oP '(?<=^VERSION_ID=).+' /etc/os-release | tr -d '"'; fi)

# Download Microsoft signing key and repository
wget https://packages.microsoft.com/config/ubuntu/$repo_version/packages-microsoft-prod.deb -O packages-microsoft-prod.deb

# Install Microsoft signing key and repository
sudo dpkg -i packages-microsoft-prod.deb

# Clean up
rm packages-microsoft-prod.deb

# Update packages
sudo apt update
```
[Microsoft: register microsoft package repo](https://learn.microsoft.com/en-us/dotnet/core/install/linux-ubuntu#register-the-microsoft-package-repository)

2. Install
```bash
# Update your package list
sudo apt update

# Install ASP.NET Core 7.0 Runtime
sudo apt install aspnetcore-runtime-7.0

# Install .NET 7.0 SDK
sudo apt install dotnet-sdk-7.0

```

## For Windows
[Microsoft: install .Net 7](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)