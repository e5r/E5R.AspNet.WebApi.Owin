@echo off

set NUGET=.\.nuget\NuGet.exe
set PACKAGE=E5R.AspNet.WebApi.Owin.nuspec

%NUGET% pack %PACKAGE%
pause