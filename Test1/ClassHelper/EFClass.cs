using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test1.DB;

namespace Test1.ClassHelper
{
    public class EFClass
    {
        public static FitnessEntities context { get; set; } = new FitnessEntities();
    }
}
