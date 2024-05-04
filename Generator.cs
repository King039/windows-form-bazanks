using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windows_form_bazanks
{
    internal class Generator
    {
        private int from;
        private int until;
        public Generator(int from, int until)
        {
            this.from = from;
            this.until = until;
            if (from > until)
            {
                int temp = this.from;
                this.from = this.until;
                until = temp;
            }
        }
        public int getNumber()
        {
            Random random = new Random();
            return random.Next(from,until + 1);
        }
    }
}
