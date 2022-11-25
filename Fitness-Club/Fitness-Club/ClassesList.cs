using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Club
{
    internal class ClassesList
    {
        List<Classes> listC;

        public ClassesList(List<Classes> listC)
        {
            this.listC = listC;
        }

        public Classes findClassById(string classId)
        {
            foreach (Classes c in listC)
            {
                if (c.ClassId == classId)
                    return c;
            }
            return null;
        }



    }
}
