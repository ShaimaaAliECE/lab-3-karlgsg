using System;
namespace Lab3App
{
	public abstract class Treasure : Collectable
	{
        public int Score { get; set; }

        public void UpdateTotalScore()
        {
            Board.TotalScore += Score;
            Console.WriteLine($"Total Score is updated to: {Board.TotalScore}");
        }
    }
}

