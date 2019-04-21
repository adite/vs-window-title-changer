@echo off

call :normalizepath "%~dp0\..\bin\vs2008\Release\VSWindowTitleChanger.dll"
set binpath=%RETVAL%

"%~dp0RegPkg" /root:"Software\Microsoft\VisualStudio\9.0" /unregister /codebase "%binpath%"
"%~dp0RegPkg" /root:"Software\Microsoft\VisualStudio\9.0" /codebase "%binpath%"
REM pause

exit /b

:normalizepath
  set RETVAL=%~dpfn1
  exit /b

