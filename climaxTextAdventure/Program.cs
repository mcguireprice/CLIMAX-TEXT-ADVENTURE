using System;

namespace climaxTextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SETTING- An old school that is now used by the dance crew. The gym is where they perform and have the party but the old classrooms have been turned into individual dorm rooms.");
            Console.WriteLine("*DANCE MUSIC PLAYS IN THE BACKGROUND*");
            Console.WriteLine("*YOU WALK OUT ON THE DANCE FLOOR WITH THE REST OF THE DANCE CREW*");
            Console.WriteLine("*YOU PERFORM THE CHOREOGRAPHED DANCE*");
            Console.WriteLine("*SONG ENDS*");
            Console.WriteLine("EMMANUELLE: Good job everyone! I am so happy to see all of your hard work starting to pay off! As you know we are heading to America tommorow and I couldn't be more proud to show the American audiences what French dancing is really about! Now I want you to all rest and have a good time before we head off tomorrow, I've made punch and set out food. Also, Daddy will be the DJ for tonight so if you want some good music make sure to kiss up to him. HAVE FUN!");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("Do you want to go hangout with your boyfriend David or go and hangout with Daddy the DJ? (TYPE: David or Daddy)");
            string choice1 = Console.ReadLine();
            if (choice1 == "David")
            {
                Console.WriteLine("*YOU START TO WALK OVER TO DAVID BUT SEE HE IS FLIRTING WITH SOMEONE ELSE.");
                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine("*Do you confront him or go to your friend Lou? (Type: David or Lou)");
                string choice11 = Console.ReadLine();
                if (choice11 == "David") 
                {

                }
                else
                {

                }
            }
            else
            {
                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine("*YOU WALK OVER TO DADDY THE DJ ON STAGE WHO IS HANGING OUT WITH THE CHOREOGRAPHER EMMANUELLE AND TITO (EMMANUELLE'S CHILD)*");
                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine("Do you ask Tito to go dance with you or talk to Emmanuelle? (Type: Dance or Talk)");
                string choice2 = Console.ReadLine();
                if (choice2 == "Dance")
                {

                }
                else
                {

                }
            }
        }
    }
    
}
