using System;
using System.Collections.Generic;

namespace Lab3App
{
	public class Coin:Treasure
	{
        private double Value;
		public Coin(string description, double score,double value)
		{
            Description = description;
            Value = value;
            Score = score;
		}

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            UpdateTotalValue();
        }

        private void UpdateTotalValue()
        {
            Board.TotalValue += Value;
            Console.WriteLine("Total Value is updated to: " + Board.TotalValue);
        }

        public override void Display()
        {
            Console.WriteLine("Coin " + Description + " is displayed");
        }
    }
}

