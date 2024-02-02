using System;
using System.Collections.Generic;

namespace Lab3App
{
	public class Diamond : Treasure
	{
        public Diamond(string description, int score)
        {
            Description = description;
            Score = score;
        }

        public override void AddMe(List<Collectable> collection)
        {
            base.AddMe(collection);
            UpdateTotalScore();
        }

        public override void Display()
        {
            Console.WriteLine($"Diamond{Description} is displayed");
        }
    }
}

