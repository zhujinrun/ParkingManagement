﻿using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Park.Admin.Models;

namespace Park.Admin
{
    [Authorize]
    public class BaseAdminModel : BaseModel
    {

    }
}
