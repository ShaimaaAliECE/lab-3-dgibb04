using System;
using System.Collections.Generic;

namespace Lab3App
{
    public abstract class Treasure: Collectable
	{
		protected double Score;
		virtual public void UpdateTotalScore()
		{
            Board.TotalScore += Score;
            Console.WriteLine("Total Score is updated to: " + Board.TotalScore);

		}
        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            UpdateTotalScore();
        }
    }
}

