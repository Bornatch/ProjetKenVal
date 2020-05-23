#Parameters
$downloadNoGetTo = “C:\Program Files (x86)\WinSCP”
$bizTalkInstallFolder = “C:\Program Files (x86)\Microsoft BizTalk Server 2016”

#Download NuGet
Write-Host “Downloading Nuget”
$sourceNugetExe = “https://dist.nuget.org/win-x86-commandline/latest/nuget.exe”
$targetNugetExe = “$downloadNoGetTonuget.exe”
Invoke-WebRequest $sourceNugetExe -OutFile $targetNugetExe

#Download the right version of WinSCP
Write-Host “Downloading WinSCP from NuGet”
Invoke-Expression “$targetNugetExe Install WinSCP -Version 5.7.7 -OutputDirectory $downloadNoGetTo”

#Copy WinSCP items to BizTalk Folder
Write-Host “Copying WinSCP Nuget to BizTalk Folder”
Copy-Item “$downloadNoGetToWinSCP.5.7.7contentWinSCP.exe” $bizTalkInstallFolder
Copy-Item “$downloadNoGetToWinSCP.5.7.7libWinSCPnet.dll” $bizTalkInstallFolder