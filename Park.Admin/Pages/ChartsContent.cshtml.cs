using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Park.Admin.Models.ViewModel;

namespace Park.Admin.Pages
{
    public class ChartsContentModel : BaseModel
    {
        public IActionResult OnGet()
        {
            ViewBag.DaysEnter = new Dictionary<DateTime, int> { { DateTime.Now.AddDays(-2).Date, 10 }, { DateTime.Now.AddDays(-1).Date, 7 }, { DateTime.Now.Date, 10 } }.Select(p => $"['{p.Key}',{p.Value}]");
            ViewBag.HoursEnter = new Dictionary<DateTime, int> { { DateTime.Now.AddDays(-2).Date, 6 }, { DateTime.Now.AddDays(-1).Date, 5 }, { DateTime.Now.Date, 10 } }.Select(p => $"['{p.Key}',{p.Value}]");

            ViewBag.DaysLeave = new Dictionary<DateTime, int> { { DateTime.Now.AddDays(-2).Date, 10 }, { DateTime.Now.AddDays(-1).Date, 9 }, { DateTime.Now.Date, 10 } }.Select(p => $"['{p.Key}',{p.Value}]");
            ViewBag.HoursLeave = new Dictionary<DateTime, int> { { DateTime.Now.AddDays(-2).Date, 4 }, { DateTime.Now.AddDays(-1).Date, 10 }, { DateTime.Now.Date, 10 } }.Select(p => $"['{p.Key}',{p.Value}]");

            ViewBag.Status = new StatusViewModel() { Total = 200, Used = 105, Empty = 95, TodayMoney = 3000 };

            ViewBag.Name = "小区停车场";
            return Page();
        }
    }
}