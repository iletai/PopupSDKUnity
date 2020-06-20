set libExport=%1

set rootPath=%~dp0..\
set unityProject="PopupSample\PopupSample\Assets\PopupSDK"

@echo "Export: %libExport%"
@echo "Root: %rootPath%"

set unityProject="PopupSample\PopupSample\Assets\PopupSDK"

if exist "%libExport%Newtonsoft.Json.dll" (
  del "%libExport%Newtonsoft.Json.dll"
)
if exist "%libExport%Newtonsoft.Json.xml" (
  del "%libExport%Newtonsoft.Json.xml"
)
if exist "%libExport%UnityEngine.dll" (
  del "%libExport%UnityEngine.dll"
)
if exist "%libExport%UnityEngine.xml" (
  del "%libExport%UnityEngine.xml"
)
if exist "%libExport%UnityEngine.UI.dll" (
  del "%libExport%UnityEngine.UI.dll"
)
if exist "%libExport%UnityEngine.UI.xml" (
  del "%libExport%UnityEngine.UI.xml"
)
xcopy /Y "%libExport%*.dll" "%rootPath%%unityProject%"
xcopy /Y "%libExport%*.xml" "%rootPath%%unityProject%"

@echo "Copied!"
Pause