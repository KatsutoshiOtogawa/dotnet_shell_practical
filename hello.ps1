
# pwsh hello.ps1

$folderlist = Get-Location | 
Split-Path | 
Get-ChildItem

foreach($folder in $folderlist){
    Write-Host $folder
}