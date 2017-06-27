@echo off
echo *** PULL: Professional CSharp 6 ***
cd GitHub_Hiersche\ProfessionalCSharp6
git pull
cd ..
cd ..

echo *** PULL: ASP.Net Core 06 2017 ***
cd GitHub_Hiersche\ASPNETCoreJun2017
git pull

echo *** PUSH: ASP.Net Core 06 2017 ***
set stunde=%TIME:~0,2%
if "%stunde:~0,1%"==" " set stunde=0%stunde:~1,1%
set minute=%TIME:~3,2%
::set sekunde=%TIME:~6,2%
set jahr=%date:~-4%
set monat=%date:~-10,2%
set tag=%date:~-7,2%
set datetime=%jahr%%monat%%tag%%stunde%%minute%
cd Hiersche_Markus
git add .
git commit -m "%datetime%"
git push