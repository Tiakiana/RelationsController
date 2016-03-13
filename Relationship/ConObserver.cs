using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations
{
    class ConObserver<T> : Observer<T>
    {
        public ConObserver(Relation<T> s)
        {
            subject = s;
        }
        public override void update()
        {
            Console.WriteLine("Current states: "+subject.relationship + " between "+subject.GetOwner()+ " and "+subject.GetOther());
        }
    }
}
