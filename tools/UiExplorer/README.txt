MMC - 2019-03-01

1) Download this package (the latest version)
 - https://www.myget.org/feed/workflow/package/nuget/UiPath.UIAutomation.Activities
2) Open the nupkg file and find the dependency version for "UiPath" here:
 - File: UiPath.UIAutomation.Activities.nuspec
 - Line: E.g. <dependency id="UiPath" version="10.0.6957.21531" />
3) Download this package (the version which is required by the UiPath.UIAutomation.Activities package)
- https://www.myget.org/feed/workflow/package/nuget/UiPath
2) Place them in the folder #packages
3) Run the install\install.bat file
4) Start UiExplorer by running UiExplorer.bat

NOTE: Use only on workstations which do not already have UiPath Studio installed.
NOTE: When changing workstation you might have to run the install again on the new workstation.