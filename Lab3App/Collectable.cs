using System;
using System.Collections.Generic;

namespace Lab3App
{
    
	abstract public class Collectable : Displayable
	{
        public CollectionBoard Board = new CollectionBoard();
        protected string Description;
        public virtual void AddMe(List<Collectable> list)
        {
            list.Add(this);
            Console.WriteLine(Description + " Collected, Congrats!!!!");
        }
        public abstract void Display();
    }
}

