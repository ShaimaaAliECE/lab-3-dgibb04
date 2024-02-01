using System;
using System.Collections.Generic;

namespace Lab3App
{
    abstract public class Tool: Collectable
    {
        public abstract void DoAction();

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            DoAction();
        }
    }
}

