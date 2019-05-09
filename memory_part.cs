using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MemoryAllocation
{
    class hole
    {

        private double address = -1;
        private double size = -1;
        private string name="";
        //for segments only
        private string hole_occupied = "";
        private Process owner=new Process();      
        public double Address
        {
            get
            {
                return address;
            }
            set
            {
                if ((value >=0) && (value <= globals.total_memory_size))
                {
                    address = value;
                }
            }
        }

        public double Size
        {
            get
            {
                return size;
            }
            set
            {
                if ((value >= 0) && (value+Address <= globals.total_memory_size))
                {
                    size = value;
                }
               
            }
        }

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

        public string Hole_Occupied
        {
            get
            {
                return hole_occupied;
            }
            set
            {

                hole_occupied = value;

            }
        }


        public Process Owner
        {
            get
            {
                return owner;
            }
            set
            {

                owner = value;

            }
        }
    }
}
