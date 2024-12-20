using AutoMapper;
using HealthTracker.Entities.Dto.Device;
using HealthTracker.Entities.Models.Device;
using HealthTracker.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace HealthTracker.Controllers
{
    public class AppController : Controller
    {
        private readonly IServiceManager serviceManager;
        private readonly IMapper mapper;
        public AppController(IServiceManager serviceManager, IMapper mapper)
        {
            this.serviceManager = serviceManager;
            this.mapper = mapper;
        }

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
        public async Task<IActionResult> NewDevice([FromForm] NewDeviceDto newDeviceDto)
        {
            if (ModelState.IsValid && newDeviceDto.DeviceName is not null)
            {
                Device? newDevice = new Device();
                mapper.Map(newDeviceDto, newDevice);
                if (newDevice is not null)
                {
                    await serviceManager.DeviceService.AddNewDevice(newDevice);
                    return RedirectToAction("DeviceList");
                }
            }
            return View(newDeviceDto);
        }
        public async Task<IActionResult> DeviceList()
        {
            List<Device> deviceList = await serviceManager.DeviceService.GetDeviceList();
            return View(deviceList);
        }
        public async Task<IActionResult> RemoveDevice([FromQuery(Name = "device-guid")] Guid guid)
        {
            await serviceManager.DeviceService.RemoveDevice(guid);
            return RedirectToAction("DeviceList");
        }
    }
}
