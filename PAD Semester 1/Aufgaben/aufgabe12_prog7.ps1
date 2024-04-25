Write-Host 'Trage Text ein'
$text = Read-Host
Write-Host 'Trage eine Zahl ein'
[int] $number = Read-Host
For ($i = 0; $i -le $number; $i++) {
    Write-Host -noNewLine $text
}
