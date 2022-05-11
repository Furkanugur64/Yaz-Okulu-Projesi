using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnityLayer
{
    public class EntityDersler
    {
        private int id;
        private int min;
        private int max;
        private string dersad;

        public int Id { get => id; set => id = value; }
        public int Min { get => min; set => min = value; }
        public int Max { get => max; set => max = value; }
        public string Dersad { get => dersad; set => dersad = value; }
    }
}
