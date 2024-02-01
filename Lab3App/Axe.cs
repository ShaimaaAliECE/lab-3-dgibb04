using System;
using System.Collections.Generic;

namespace Lab3App
{
    public class Axe : Tool
	{
        
		public Axe(string description)
		{
            Description = description;
		}

        public override void DoAction()
        {
            Console.WriteLine("Axe is Used");
        }
        public override void Display()
        {
            Console.WriteLine("Axe " + Description + " is displayed");
        }
    }
}

