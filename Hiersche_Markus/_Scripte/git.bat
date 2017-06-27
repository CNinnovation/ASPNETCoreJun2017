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
cd Hiersche_Markus
git add .
git commit -m "..."
git push