﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTProjekt.Model
{
    public class CarMercedes : CarCreator
    {
        public override Car Create()
        {
            return new Mercedes();
        }
    }
}
