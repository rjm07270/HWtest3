using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWtest3
{
    class GPUdata
    {
        public string Name
        { get; set; }
        public float temp
        { get; set; }
        public float coreLoad
        { set; get; }
        public float coreFrequency
        { set; get; }
        public float? memorySizeGB
        { set; get; }
        public float memoryInUseGB
        { set; get; }
        public float memoryFrequency
        { set; get; }


        public GPUdata()
        {

        }

    }
}
