Description
-----------------
bootable-usb is a utility that will allow you to make a bootable
USB drive from a ISO file, from a Linux terminal.

This program is written in  C# dotnet core.
Written by digimonster.co.za aka Theo Uys

You need dotnet runtime installed on your system and offcourse
the zip file (bootable-usb.zip), a USB drive and an ISO file.
That is it.

First, install dotnet runtime and then unzip the zip file and you're good
to go.

Install dotnet runtime 
-----------------------
sudo apt-get update
sudo apt-get install apt-transport-https
sudo apt-get update
sudo apt-get install dotnet-runtime-3.1

Unzip the binaries
------------------
Unzip the bootable-usb.zip file


How to Execute
--------------
Create a directory and unzip the file into it.
then run it from that directory with root priviledges like this:
sudo ./bootable-usb

Make sure you insert the USB drive into your system and make sure the system regocnizes it 
You will then be good to go.

Additional Info
----------------

This application starts up asking you to press enter.
This will supply you a list of all the USB devices in your system.
Make sure you select the correct USB drive and make sure it was inserted before
pressing enter.

USB drives normally looks like this /dev/sdb
Then select your ISO file. Then wait for the dd command to finish.
That is it.

