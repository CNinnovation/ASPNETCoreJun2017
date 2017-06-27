@echo off

set stunde=%TIME:~0,2%
if "%stunde:~0,1%"==" " set stunde=0%stunde:~1,1%
set minute=%TIME:~3,2%
::set sekunde=%TIME:~6,2%
set jahr=%date:~-4%
set monat=%date:~-10,2%
set tag=%date:~-7,2%
set datetime=%jahr%%monat%%tag%%stunde%%minute%
robocopy C:\Users\Student\Desktop %~d0\%datetime%\Desktop /MIR /R:1 /W:1
::robocopy C:\Users\Student\Documents %~d0\%datetime%\Documents /MIR /R:1 /W:1
::echo %datetime%
pause
