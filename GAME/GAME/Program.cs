﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MemberManager memberManager = new MemberManager();
            memberManager.Save();



            Console.ReadLine();
        }
    }
}
