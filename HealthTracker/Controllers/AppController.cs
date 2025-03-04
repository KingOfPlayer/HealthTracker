﻿using AutoMapper;
using HealthTracker.Entities.Dto.Device;
using HealthTracker.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HealthTracker.Controllers
{
    public class AppController(IServiceManager serviceManager) : Controller
    {
        private readonly IServiceManager serviceManager = serviceManager;

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult NewDevice()
        {
            return View();
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> NewDevice([FromForm] DeviceNameDto newDeviceDto)
        {
            if (ModelState.IsValid && newDeviceDto.DeviceName is not null)
            {
                await serviceManager.DeviceService.AddNewDevice(newDeviceDto);
                return RedirectToAction("DeviceList");
            }
            return View(newDeviceDto);
        }
        public async Task<IActionResult> DeviceList()
        {
            IEnumerable<DeviceDto> deviceList = await serviceManager.DeviceService.GetDeviceList();
            return View(deviceList);
        }
        public async Task<IActionResult> RemoveDevice([FromQuery(Name = "device-guid")] Guid guid)
        {
            await serviceManager.DeviceService.RemoveDevice(new DeviceGuidDto(guid));
            return RedirectToAction("DeviceList");
        }

        public async Task<IActionResult> DeviceDetails(Guid id)
        {
            DeviceDetailsDto? deviceDetailsDto = await serviceManager.DeviceService.GetDeviceDetails(new DeviceGuidDto(id));
            if (deviceDetailsDto == null)
                return RedirectToAction("DeviceList");

            ViewBag.DeviceName = deviceDetailsDto.DeviceName;
            ViewBag.DeviceGuid = deviceDetailsDto.DeviceGuid;
            IEnumerable<DeviceDataDto> deviceDataDtos = await serviceManager.DeviceDataService.GetDeviceDatas(deviceDetailsDto);
            ViewBag.DeviceDatas = deviceDataDtos;
            return View();
        }
    }
}
