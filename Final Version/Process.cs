using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryAllocation
{
    class Process
    {
        private string name = "";
        bool fit = true;
        bool allocated = false;
        public LinkedList<hole> segments=new LinkedList<hole>() ;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {

                name = value;

            }
        }
        public bool Fit
        {
            get
            {
                return fit;
            }
            set
            {

                fit = value;

            }
        }
        public bool Allocated
        {
            get
            {
                return allocated;
            }
            set
            {

                allocated = value;

            }
        }

    }
}
