using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations
{
    class Program
    {
        //This is the implementation of it.
        public void OnChange(float relationship, string Owne, string Othe) {
            if (true)
            {

            }
        }
        static void Main(string[] args)
        {
            RelationshipController<string> rc = RelationshipController<string>.GetRelaCont();
            Program p = new Program();


            rc.CreateRelation("Denmark", "USA");
            rc.OnRelationshipChange += p.OnChange;

            rc.ChangeRelationship("Denmark", "USA", -10);
            rc.ChangeRelationship("Denmark", "USA", -20);
            
            rc.CreateRelation("Germany", "USA");
            rc.CreateRelation("Sweden", "USA");
            rc.ChangeRelationship("Denmark", "USA", 5);
           
            Console.Read();
        }
    }
}
