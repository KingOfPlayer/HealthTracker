# Health Tracker
This repo aim store Spo2, BPM, Temperature and humidity data from ESP32-WROOM device on ASP.NET environment like a blynk and arduino cloud  
  
## Requirements  
1. For Web Server ASP.NET  
  >dotnet   
  >dotnet-ef  
  >MSSQL  
2. For ESP32-WROOM Device
  >Arduino ide

## Web Server ASP.NET  
1. Init User secrets 
  >Execute in HealthTracker folder  
  >`dotnet user-secrets init`
2. Set your SQL Connection for SQL Database  
  >Execute in HealthTracker folder  
  >`dotnet user-secrets set "ConnectionStrings:mssqlconnection" "Server=localhost;Database=<DBNAME>;User Id=<USERID>;Password=<PASSWORD>;Trusted_Connection=False; Encrypt=True;`  
  
### Run The Project
  >Execute in HealthTracker folder  
  >`dotnet watch --environment Development --urls="http://<IP>:80"`  
  >Note: if u want https u need change http to https in ESP32 device code 

## ESP32-WROOM Device
1. Install ESP32 board, MAX30100 and DTH11 library on Arduino ide
2. Source Code
  >Get Source code archive in `HealthTracker/wwwroot/Esp32SoruceCode` folder or when web server working u can download with button in device details page  
  >Extract archive and open on Arduino ide  
  >Edit this lines and install to ESP32-WROOM
```
#define SSID "WIFI_NAME"  
#define PASSWORD "WIFI_PASSWORD"  

#define Host "HOST_NAME"  
#define DeviceGuid "---- DEVICE GUID ----"
```
  >Note: `---- DEVICE GUID ----` this part is generated by using the new device page on the web server.  
3. Sensor Connections  
  >MAX30100 using I2C pins  
  >DTH11 using default pin 4 (u can change pin on source code)  
