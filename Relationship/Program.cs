using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations
{
    class Program
    {
        //This is what we thinkt the party should do with the information
        public void OnChange(float relationship, string Owne, string Othe) {
            if (relationship< -10)
            {
                Console.WriteLine(Owne + " Declares war on " + Othe);
            }
            if (relationship>10)
            {
                Console.WriteLine(Owne + " allies with " + Othe);

            }
        }
        // This class is only for example
        static void Main(string[] args)
        {
            //First up we instantiate the relationship controller with the type of
            //thing that should have relations.
            //this could be a class or in this case just a string.
            RelationshipController<string> rc = RelationshipController<string>.GetRelaCont();
            //We here make a pseudo program
            Program p = new Program();

            //Here we create the relation between 2 strings
            rc.CreateRelation("Denmark", "USA");
            //then we subscribe what should be done once the relationship changes
            rc.OnRelationshipChange += p.OnChange;

            //Then Denmark discovers USA's secret plans to invade Greenland
            rc.ChangeRelationship("Denmark", "USA", -11);
            
           //Boom nuclear war is emminent!
            Console.Read();
        }
    }
}
