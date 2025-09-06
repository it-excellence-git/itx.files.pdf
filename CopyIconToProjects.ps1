# Copies the solution-level itx.png icon to each project folder if not present
$solutionDir = Split-Path -Parent $MyInvocation.MyCommand.Path
 
$projectDirs = @(
    "itx.files.pdf",
    "itx.files.pdf.zugferd.abstractions",
    "itx.files.pdf.zugferd"
)
foreach ($dir in $projectDirs) {
    $target = Join-Path $solutionDir $dir
    $iconTarget = Join-Path $target "itx.png"
    if (!(Test-Path $iconTarget) -and (Test-Path $iconSource)) {
        Copy-Item $iconSource $iconTarget
        Write-Host "Copied itx.png to $target"
    }
}
Write-Host "Icon copy complete."
