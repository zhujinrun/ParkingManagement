using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Park.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using FineUICore;

namespace Park.Admin.Pages.Admin
{
    public class DatabaseManageModel : BaseAdminModel
    {
        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostResetAdminDatabaseAsync()
        {
            await DB.Database.EnsureDeletedAsync();
            ParkAdminDatabaseInitializer.Initialize(DB);
            ShowNotify("操作成功，请重新登录");
            return UIHelper.Result();
        }

        public IActionResult OnPostGenerateTestData(int count)
        {
            Console.WriteLine(count);
            ShowNotify("操作成功");
            return UIHelper.Result();
        }
    }
}