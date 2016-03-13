using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations
{
    public abstract class Observer<T>
    {
        public Relation<T> subject;
        public abstract void update();
    }
}
