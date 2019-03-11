


If ($copyblob -eq $true) { 
    # Blob doesn't exist, upload the blob with lastwrite metadata 
    Write-Log -Value "Copying local file $($file.Name) to blob $blobname in container $Container" 
    $Extn = [IO.Path]::GetExtension($file.FullName) ######################################################################Need to set Content Type
    $ContentType = ""
    # types missing altogether, add them below
    switch ($Extn) {
        ".html" { $ContentType = "text/html" }
        ".htm" { $ContentType = "text/html" }
        ".css" { $ContentType = "text/css" }
        ".txt" { $ContentType = "text/plain" }
        ".xml" { $ContentType = "application/xml" }
        ".json" { $ContentType = "application/json" }
        ".js" { $ContentType = "application/javascript" }
        ".svg" { $ContentType = "image/svg+xml" }
        ".png" { $ContentType = "image/png" }
        ".jpg" { $ContentType = "image/jpeg" }
        ".ico" { $ContentType = "image/x-icon" }
        Default { $ContentType = "" }
    }
    try { 
        $output = Set-AzureStorageBlobContent -File $file.FullName -Blob $blobname -Container $Container -Context $context -Properties @{"ContentType" = $ContentType} -Metadata @{"lastwritetime" = $file.LastWriteTimeUTC.Ticks} -Force -ErrorAction SilentlyContinue 
    } catch { 
        Write-Log -Value "ERROR: Could not copy file to Azure blob $($blobname): $($_.Exception.Message)" -Color Red 
    } 
}


Login-AzureRMAccount; (get-AzureRmCdnProfile).where({$_.name -eq 'rainweb'}) | Get-AzureRmCdnEndpoint | 
	Unpublish-AzureRmCdnEndpointContent -PurgeContent "/*"
