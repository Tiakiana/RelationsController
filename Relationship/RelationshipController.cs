using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations
{


    class RelationshipController<T>
    {
        private static volatile RelationshipController<T> inst;
        private List<Relation<T>> IngameRelations;
        public static RelationshipController<T> GetRelaCont() {
            if (inst == null)
            {
                inst = new RelationshipController<T>();
            }
            return inst;
        }
        public RelationshipController() {
            IngameRelations = new List<Relation<T>>();
        }

         void AddRelationship(Relation<T> rela) {
        
           rela.OnRelationshipChange += ListenForChange;
        }

        public void RemoveRelationship(Relation<T> rela)
        {
     
          rela.OnRelationshipChange -= ListenForChange;
        }

        public void CreateRelation(T own, T oth) {
            Relation<T> r = new Relation<T>(own, oth);
            AddRelationship(r);
           
        }

        public void ChangeRelationship(T own, T oth, float chng) {
            IngameRelations.Find(x => x.GetOwner().Equals(own) && x.GetOther().Equals(oth)).SetRelationship(chng);
        }


        void ListenForChange(float relation, T owne, T othe) {

            OnRelationshipChange(relation, owne, othe);

        }
 
        public delegate void BroadcastChange(float relationship, T Owne, T Othe);
        public event BroadcastChange OnRelationshipChange;







    }
}
