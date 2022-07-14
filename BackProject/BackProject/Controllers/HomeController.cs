using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Business.Services;
using Business.ViewModels;
using DAL.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace BackProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISliderService _sliderService;
        private readonly IAboutService _aboutService;
        public HomeController(ISliderService sliderService, IAboutService aboutService)
        {
            _sliderService = sliderService;
            _aboutService = aboutService;
        }


        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM();

            homeVM.Sliders = await _sliderService.GetAll();
            homeVM.About = await _aboutService.GetAll();

            return View(homeVM);
        }
    }
}

