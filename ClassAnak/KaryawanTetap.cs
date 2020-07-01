using System;
using System.Collections.Generic;
using System.Text;

namespace Tugaslab09.ClassAnak
{
    public class KaryawanTetap : Karyawan
    {

        public double GajiBulanan;
        public override double Gaji()
        {
            return this.GajiBulanan;
        }
    }
}