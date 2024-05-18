﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Data.Abtractions.Entities
{
    public interface ISoftDelete
    {
        bool IsDelete { get; set; }
        DateTimeOffset DeleteDate { get; set; }
    }
}
