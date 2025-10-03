using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo7
{
    public class Staticexample
    {
        public static int classid {  get; private set; }

        public int internalclassid { get; private set; }

        public Staticexample()
        {
            classid++;
            internalclassid = classid;
        }

        public void Naoestatico()
        {
        
        }


    }
}
