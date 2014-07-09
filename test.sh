#!/bin/bash

xbuild /p:Configuration="Debug" Wunderground.Net.sln /flp:LogFile=xbuild.log;Verbosity=Detailed

#cd Run/Tests/Debug
#nunit-console Test.dll
