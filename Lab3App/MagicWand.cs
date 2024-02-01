using System;
using System.Collections.Generic;

namespace Lab3App
{
	public class MagicWand : Tool
	{
		public MagicWand(string description)
		{
            Description = description;
		}

        public override void DoAction()
        {
            Console.WriteLine("MagicWand is Used");
        }
        public override void Display()
        {
            Console.WriteLine("MagicWand " + Description + " is displayed");
        }
    }
}

