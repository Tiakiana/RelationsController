using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations
{
    public class Subject
    {
        public float relationship { get; set; }
        public float getState()
        {
            return relationship;
        }
        public void setState(float relationship)
        {
            this.relationship = relationship;
        }
    }
}
