﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoToan
{
    class Quan8 : QuanCo
    {
        public override int KiemTra(int i, int j)
        {
            turn = false;
            {
                IsValue(i, j, this.gtri);
            }

            if (turn == true) return 1;
            else return 0;
        }
    }
}
