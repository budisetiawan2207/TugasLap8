using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classanak
{
    public abstract class Karyawan
    {
        public String Nik { get; set; }
        public String Nama { get; set; }
        public abstract double Gaji();
    }
}
