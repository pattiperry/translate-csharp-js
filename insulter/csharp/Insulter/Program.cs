using System;
using System.Collections.Generic;




//namespace tells us what directory we're in 
//namespace is a collection of related classes
namespace Insulter
{
    class Program
    {
        static void Main(string[] args)
        {
            // We must specify the Type of the "insults" variable.
            //  It is a "List" that can only contain "strings".
          List<string> insults = new List<string>() {
              "You look like what morning breath smells like.",
              "If you tried to give me cpr I would probably throw myself back under water",
              "I am not a fan of you",
              "You think you're so special...and you are. The fact of your existence is nearly impossible to believe",
              "I'd rather walk than be on the same plane as you",
              "If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy",
              "Do you have to be so...like that?"
          };

              //while loop that insure we don't end up with duplicate insults
              List<int> indexes = new List<int>() {};
                while (indexes.Count < 3) 
                {
                  int candidate = Number();
                  if (!indexes.Contains(candidate))
                  {
                    indexes.Add(candidate);
                  }
                }

              //for loop
              for (int i=0; i<indexes.Count; i++) 
                  {
                  int index = indexes[i];
                  Console.WriteLine(insults[index]);
                  }

              //getting a random integer
              // this is a function
              //  Generates a random number between 1 and 6
              
              static int Number()
              {
                  var numValue = new Random().Next(0, 7);
                  return numValue;
              }
        }
                  }
              }


