using System;
using System.Collections.Generic;

namespace Lab3App
{
	public class Coin : Treasure
	{
        public int Value { get; set; }

        public Coin(string description, int score, int value) : base()
        {
            Description = description;
            Score = score;
            Value = value;
        }

        public override void AddMe(List<Collectable> collection)
        {
            base.AddMe(collection);
            UpdateTotalScore();
            UpdateTotalValue();
        }

        public void UpdateTotalValue()
        {
            Board.TotalValue += Value;
            Console.WriteLine($"Total Value is updated to: {Board.TotalValue}");
        }

        public override void Display()
        {
            Console.WriteLine($"Coin {Description} is displayed");
        }
    }
}

