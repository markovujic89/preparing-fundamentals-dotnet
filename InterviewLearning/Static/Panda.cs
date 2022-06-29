using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewLearning.Static
{
    public class Panda
    {
        public string Name;

        public static int Population;

        public Panda(string name)
        {
            Name = name;
            Population++;
        }
    }
}
