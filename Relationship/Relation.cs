using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations
{
    public class Relation<T> : Subject
    {
        public T owner { get; }
        public T other { get; }
        //bool tradeAgreement { get; set; }
        /// <summary>
        /// This Class can be used to make relationships
        /// between instances of object. You will have to 
        /// define what type of object these relationships can be
        /// coupled to.
        /// </summary>
        /// <param name="own"></param>
        /// <param name="oth"></param>

        public Relation()
        {
            
        }
        public Relation(T own, T oth)
        {
            owner = own;
            other = oth;
            relationship = 0;
        }
        public Relation(T own, T oth, bool BothWays) {
            owner = own;
            other = oth;
            relationship = 0;
        }

        public T GetOther() { return other; }
        public T GetOwner() { return owner; }
        public float GetRelationship()
        {
            return relationship;
        }
        public void SetRelationship(float chng)
        {
            relationship = chng;
           OnRelationshipChange(relationship, owner, other);

        }

        // need the current relationship and
        public delegate void RelationshipChanged(float relationship, T Owne, T Othe);
        public event RelationshipChanged OnRelationshipChange;

        
    }
}
