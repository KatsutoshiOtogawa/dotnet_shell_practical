
# pwsh hello2.ps1

Get-Location | 
Split-Path | 
Get-ChildItem |
ForEach-Object {
    Write-Host $_
}
