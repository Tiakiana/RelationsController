using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations
{
    class Program
    {
        
        static void Main(string[] args)
        {
            RelationshipController<string> rc = RelationshipController<string>.GetRelaCont();
            rc.CreateRelation("Denmark", "USA");
            rc.ChangeRelationship("Denmark", "USA", -10);
            rc.ChangeRelationship("Denmark", "USA", -20);
            
            rc.CreateRelation("Germany", "USA");
            rc.CreateRelation("Sweden", "USA");
            rc.ChangeRelationship("Denmark", "USA", 5);
            rc.notifyAllObservers();
            Console.Read();
        }
    }
}
