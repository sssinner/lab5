using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassRoom classRoom = new ClassRoom(new ExcelentPupil(), new BadPupil(), new GoodPupil());
            classRoom.ShowPupils();
        }
    }
}