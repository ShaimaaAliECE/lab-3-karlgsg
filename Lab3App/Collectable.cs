using System;
using System.Collections.Generic;

namespace Lab3App
{
    public abstract class Collectable : Displayable
    {
        public string Description { get; set; }
        public CollectionBoard Board { get; set; }

        public virtual void AddMe(List<Collectable> collection)
        {
            collection.Add(this);
            Console.WriteLine($"{Description} Collected, Congrats!!!!");
        }

        public abstract void Display();

    }
}


