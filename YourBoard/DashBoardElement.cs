﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourBoard
{
    public abstract class DashBoardElement
    {
        public abstract void Create();
        public abstract void Delete();
        public abstract void Move();
    }
}