﻿using Integration.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integration.Service.Abstractions;

internal interface IIntegrationService
{
    public Result SaveItem(string itemContent);
    public List<Item> GetAllItems();

}
