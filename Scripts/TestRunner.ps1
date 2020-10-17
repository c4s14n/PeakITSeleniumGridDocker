Param (
   
    [Parameter(Mandatory=$true)]
	[string]$Browser
)

$BrowserArray=$Browser.Split(",")
$BrowserArray | ForEach-Object -Parallel { 
    "Running Tests on $_"
    nunit3-console.exe --testparam:Browser=$_ "<YOUR_PATH_TO_BIN_FILES>\SeleniumGridWithDocker.dll"
    Rename-Item -Path "TestResult.xml" -NewName "TestResults$_.xml"
    "Tests running on $_ ended"
    }