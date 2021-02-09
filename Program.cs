using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework6.HelpMaterial;
using Homework6.Job1;
using Homework6.Job3;

namespace Homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            Heroes.ShowPersonDescription();
            Heroes.ShowLeftJoinQuerySyntax();
            MyDB.UpdateCharacter();
             Console.ReadKey();
        }



    }
}
