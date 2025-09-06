# BuildNuGetPackages.ps1
# Builds NuGet packages for all projects in the solution and stores them in a NuGet folder beside the solution directory.

param(
    [string]$SolutionDir = (Split-Path -Parent $MyInvocation.MyCommand.Path)
)

$nugetDir = Join-Path (Split-Path $SolutionDir -Parent) "NuGet"
if (-not (Test-Path $nugetDir)) {
    New-Item -ItemType Directory -Path $nugetDir | Out-Null
}

Write-Host "NuGet output directory: $nugetDir"

# Find all packable .csproj files
$projects = Get-ChildItem -Path $SolutionDir -Recurse -Filter *.csproj | Where-Object {
    $content = Get-Content $_.FullName -Raw
    $content -notmatch '<IsPackable>\s*false\s*</IsPackable>'
}


# Copy icon to each project folder if not present
$iconSource = Join-Path $SolutionDir "..\itx.png"
Write-Host "Icon source $iconSource"
foreach ($proj in $projects) {
    $projDir = Split-Path $proj.FullName -Parent
    $iconTarget = Join-Path $projDir "itx.png"
    if (!(Test-Path $iconTarget) -and (Test-Path $iconSource)) {
        Copy-Item $iconSource $iconTarget
        Write-Host "Copied itx.png to $projDir"
    }
}

foreach ($proj in $projects) {
    Write-Host "Packing $($proj.Name)..."
    dotnet pack $proj.FullName -c Release --output $nugetDir --include-symbols --include-source
}

Write-Host "All NuGet packages are stored in: $nugetDir"
