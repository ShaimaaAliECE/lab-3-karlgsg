using System;
using System.Collections.Generic;

namespace Lab3App
{
	public abstract class Tool : Collectable
	{

        public override void AddMe(List<Collectable> collection)
        {
            base.AddMe(collection);
            DoAction();
        }

        public abstract void DoAction();
    }

}


