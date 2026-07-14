# Copyright (c) FluentHub
# Licensed under the MIT License.
# Builds FluentHub as a standalone .exe

param(
    [string]$Platform = "x64",
    [string]$Configuration = "Release",
    [bool]$CreateZip = $true
)

$ErrorActionPreference = "Stop"

$ProjectPath = Join-Path $PSScriptRoot "..\..\src\FluentHub.App\FluentHub.App.csproj"
$PublishDir = Join-Path $PSScriptRoot "..\..\publish\$Platform"
$OutputZip = Join-Path $PSScriptRoot "..\..\publish\FluentHub-$Platform.zip"

Write-Host "Building FluentHub.exe for $Platform ($Configuration)..." -ForegroundColor Cyan

# Clean previous build
if (Test-Path $PublishDir) {
    Remove-Item -Recurse -Force $PublishDir
}

# Publish the app
Write-Host "Publishing..." -ForegroundColor Yellow
dotnet publish $ProjectPath `
    -r "win-$Platform" `
    -c $Configuration `
    --self-contained true `
    -p:PublishSingleFile=true `
    -p:IncludeNativeLibrariesForSelfExtract=true `
    -p:EnableCompressionInSingleFile=true `
    -p:PublishAot=false `
    -o $PublishDir

if ($LASTEXITCODE -ne 0) {
    Write-Host "Publish failed!" -ForegroundColor Red
    exit 1
}

# Create zip if requested
if ($CreateZip) {
    Write-Host "Creating zip archive..." -ForegroundColor Yellow
    
    if (Test-Path $OutputZip) {
        Remove-Item -Force $OutputZip
    }
    
    Compress-Archive -Path "$PublishDir\*" -DestinationPath $OutputZip
    
    $zipSize = [math]::Round((Get-Item $OutputZip).Length / 1MB, 2)
    Write-Host "Created: $OutputZip ($zipSize MB)" -ForegroundColor Green
}

Write-Host "Build complete!" -ForegroundColor Green
Write-Host "Output: $PublishDir" -ForegroundColor Cyan
