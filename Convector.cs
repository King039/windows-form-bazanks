using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windows_form_bazanks
{
    internal class Convector
    {
        private double current;
        private readonly double Kelvin;

        public Convector(double current)
        {
            this.current = current;
        }
        public double toSm() => 0.1 * current;
        public double toDm() => 0.01 * current;
        public double toMetr() => 0.001 * current;
        public double toKm() => 0.0001 * current;
        public double toKelvin() => current + this.Kelvin;
        public double toFarengait() => 1.8 * current + 32;
        public double toMmRtSt() => current * 0.0075;
        private double toBar() => current * 0.00001;
        private double toAtm() => current * 0.00001;
        private double toKgS() => current * 10.2 * 0.000001;
    }
}
