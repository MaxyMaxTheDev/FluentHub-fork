# Copyright (c) 2024 0x5BFA
# Licensed under the MIT License. See the LICENSE.

param(
    [string]$StorePackagePath = "",
    [string]$PartnerCenterClientId = "",
    [string]$PartnerCenterClientSecret = "",
    [string]$PartnerCenterSellerId = "",
    [string]$PartnerCenterStoreId = "",
    [string]$PartnerCenterTenantId = "",
    [bool]$Submit = $false,
    [string]$FlightId = "",
    [string]$PackageRolloutPercentage = ""
)

$ErrorActionPreference = "Stop"

$requiredValues = @{
    StorePackagePath            = $StorePackagePath
    PartnerCenterClientId       = $PartnerCenterClientId
    PartnerCenterClientSecret   = $PartnerCenterClientSecret
    PartnerCenterSellerId       = $PartnerCenterSellerId
    PartnerCenterStoreId        = $PartnerCenterStoreId
    PartnerCenterTenantId       = $PartnerCenterTenantId
}

foreach ($requiredValue in $requiredValues.GetEnumerator())
{
    if ([string]::IsNullOrWhiteSpace($requiredValue.Value))
    {
        throw "Missing required Microsoft Store publish value: $($requiredValue.Key)."
    }
}

if (-not (Test-Path -LiteralPath $StorePackagePath -PathType Leaf))
{
    throw "The Store package does not exist: $StorePackagePath"
}

msstore reconfigure `
    --tenantId $PartnerCenterTenantId `
    --sellerId $PartnerCenterSellerId `
    --clientId $PartnerCenterClientId `
    --clientSecret $PartnerCenterClientSecret

if ($LASTEXITCODE -ne 0)
{
    throw "msstore reconfigure failed with exit code $LASTEXITCODE."
}

$publishArgs = @(
    "publish",
    $StorePackagePath,
    "--appId",
    $PartnerCenterStoreId
)

Write-Host "Publishing package '$StorePackagePath' to Microsoft Store app '$PartnerCenterStoreId'."

if (-not $Submit)
{
    $publishArgs += "--noCommit"
    Write-Host "The submission will stay as a draft because Submit is false."
}

if (-not [string]::IsNullOrWhiteSpace($FlightId))
{
    $publishArgs += @("--flightId", $FlightId)
}

if (-not [string]::IsNullOrWhiteSpace($PackageRolloutPercentage))
{
    $publishArgs += @("--packageRolloutPercentage", $PackageRolloutPercentage)
}

msstore @publishArgs

if ($LASTEXITCODE -ne 0)
{
    throw "msstore publish failed with exit code $LASTEXITCODE."
}
