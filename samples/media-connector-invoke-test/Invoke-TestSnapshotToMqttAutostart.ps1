#Requires -Version 7

$aioConnectorsNamespace = (Get-Content -Path (Join-Path -Path $PSScriptRoot -ChildPath ".config_aio_connectors_namespace") -Raw).Trim()
Write-Host "AIO connectors namespace: $aioConnectorsNamespace"

$aepName = "aep-public-http-anonymous-1"
Write-Host "AEP name: $aepName"

$assetName = "asset-public-http-anonymous-1-snapshot-to-mqtt-autostart"
Write-Host "Asset name: $assetName"

$datapointName = "snapshot-to-mqtt"
Write-Host "Datapoint name: $datapointName"

. (Join-Path -Path $PSScriptRoot -ChildPath "Invoke-ResourceInstallMonitorAndUninstall.ps1") `
    -aepName $aepName `
    -assetName $assetName `
    -datapointName $datapointName `
    -monitorExpresion `
        "& (Join-Path -Path $PSScriptRoot -ChildPath `"Start-MqttListener.ps1`") -listenTopics $aioConnectorsNamespace/data/$assetName/#"
