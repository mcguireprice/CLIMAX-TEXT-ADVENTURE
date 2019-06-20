using System;

namespace climaxTextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?:");
            string name = Console.ReadLine();
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("SETTING- An old school that is now used by the dance crew. The gym is where they perform and have the party but the old classrooms have been turned into individual dorm rooms.");
            Console.WriteLine("*DANCE MUSIC PLAYS IN THE BACKGROUND*");
            Console.WriteLine("*YOU WALK OUT ON THE DANCE FLOOR WITH THE REST OF THE DANCE CREW*");
            Console.WriteLine("*YOU PERFORM THE CHOREOGRAPHED DANCE*");
            Console.WriteLine("*SONG ENDS*");
            Console.WriteLine("EMMANUELLE: Good job everyone! I am so happy to see all of your hard work starting to pay off! As you know we are heading to America tommorow and I couldn't be more proud to show the American audiences what French dancing is really about! Now I want you to all rest and have a good time before we head off tomorrow, I've made alcoholic punch and set out food. Also, Daddy will be the DJ for tonight so if you want some good music make sure to kiss up to him. HAVE FUN!");

            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("Do you want to go hangout with your boyfriend David or go and hangout with Daddy the DJ? (TYPE: David or Daddy)");
            string choice1 = Console.ReadLine();

            if (choice1 == "David" || choice1 == "david")
            {
                Console.WriteLine("*YOU START TO WALK OVER TO DAVID BUT SEE HE IS FLIRTING WITH SOMEONE ELSE.");

                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine("*Do you confront him or go to your friend Lou? (Type: David or Lou)");
                string choice11 = Console.ReadLine();

                if (choice11 == "David") 
                {
                    Console.WriteLine("*YOU WALK UP TO DAVID AND SEE HE IS FLIRTING WITH ANOTHER DANCER, LEA*");
                    Console.WriteLine("YOU: Nice to know you are having fun.");
                    Console.WriteLine("*DAVID LETS GO OF LEA. LEA LEAVES AND SCOFFS IN YOUR FACE*");
                    Console.WriteLine("DAVID: What are you jealous. *HE SMILES* You know I was just having fun. Come on lets go dance.");

                    Console.WriteLine("---------------------------------------------------------------------------");
                    Console.WriteLine("Do you go dance with David or go talk to your choerographter Emmanuelle? (Type Dance or Emmanuelle)");
                    string choice12 = Console.ReadLine();

                    if (choice12 == "Dance" || choice12 == "dance")//Dance with David
                    {
                        Console.WriteLine("YOU: Fine. But don't expect me to hae any fun.");
                        Console.WriteLine("DAVID: Don't worry, I won't have any either, but first lets get something to drink or eat!");
                        Console.WriteLine("*HE SMILES AND DRAGS YOU TO THE DRINK TABLE*");
                        Console.WriteLine("*HE FIXES HIMSELF A CUP AND DRINKS IT IN ONE GULP, HE THEN MAKES ANOTHER CUP AND OFFERS IT TO YOU*");

                        Console.WriteLine("---------------------------------------------------------------------------");
                        Console.WriteLine("Do you take the cup or decline?:");
                        string choice14 = Console.ReadLine();
                    }
                    else//Go talk to Emmanuelle
                    {

                    }
                }
                else // Talk to Lou
                {
                    Console.WriteLine("*YOU WALK OVER TO LOU WHO IS SITTING IN A CHAIR AGAINST THE WALL, SHE SEEMS DISTANT FROM THE PARTY GOING ON*");
                    Console.WriteLine("YOU: What's up with you?");
                    Console.WriteLine("LOU: Not feeling great.");
                    Console.WriteLine("YOU: Want me to get you some punch?");
                    Console.WriteLine("LOU: No, I think that would make me feel worse.");

                    Console.WriteLine("---------------------------------------------------------------------------");
                    Console.WriteLine("Do you try lift Lou's spirit or go hang out with David? (Type Lift Spirit or Hang With David");
                    string choice13 = Console.ReadLine();

                    if (choice13 == "Lift Spirit" || choice13 == "lift spirit")// lift Lou's spirit
                    {

                    }
                    else //Go Hangout with David
                    {
                            
                    }
                }
            }
            else // Walk to Daddy
            {
                Console.WriteLine("*YOU WALK OVER TO DADDY THE DJ ON STAGE WHO IS HANGING OUT WITH THE CHOREOGRAPHER EMMANUELLE AND TITO (EMMANUELLE'S CHILD)*");

                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine("Do you ask Tito to go dance with you or talk to Emmanuelle? (Type: Dance or Talk)");
                string choice2 = Console.ReadLine();

                if (choice2 == "Dance" || choice2 == "dance")
                {
                    Console.WriteLine("*YOU WALK UP TO TITO AND HOLD OUT YOUR HAND*");
                    Console.WriteLine("YOU: Hey Tito, wanna dance?");
                    Console.WriteLine("*TITO GRABS YOUR HAND AND YOU START TO WALK TO THE MIDDLE OF THE DANCE FLOOR*");
                    Console.WriteLine("EMMANUELLE: Tito! Remember what I told you, you can't have any of the punch, it has alcohol and alcohol is not for children! And" + " " + name + " " + "get some punch! It took forever for me to make!");
                    Console.WriteLine("*AS YOU WALK OUT ON THE DANCE FLOOR YOU RUN INTO IVANA AND PSYCHE*");
                    Console.WriteLine("IVANA: Hey" + " " + name + " " + "do you have anything to help me liven the mood a bit?");

                    Console.WriteLine("---------------------------------------------------------------------------");
                    Console.WriteLine("Do you give them some your personal stash of weed or not? (Type: Give or Lie)");
                    string Choice21 = Console.ReadLine();

                    if (Choice21 == "Give" || Choice21 == "give")//Give Psyche and Ivana weed
                    {
                        Console.WriteLine("YOU: Here, but I expect atleast some money in return.");
                        Console.WriteLine("*YOU GIVE THEM SOME WEED OUT OF YOUR POCKET*");
                    }
                    else // Lie about the weed
                    {
                        Console.WriteLine("You: Sorry, I'm out. I'd check Elise, she is always on something. She'll hook you two up.");
                        Console.WriteLine("PSYCHE: Not me, after seeing my roommate drip stuff in her eyes for a high I knew I had to get out of there.");
                    }
                }
                else // Talk to Emmanuelle and Daddy
                {
                    Console.WriteLine("*You walk up to Emmanuelle and hug her from behind*");
                    Console.WriteLine("YOU: How was it really?");
                    Console.WriteLine("EMMANUELLE: AMAZING! I really couldn't be more proud.");
                    Console.WriteLine("YOU: I am honestly still so nervous.");
                    Console.WriteLine("EMMANUELLE: You are doing amazing! Give yourself a break and let loose a little. Go have some punch!");

                    Console.WriteLine("---------------------------------------------------------------------------");
                    Console.WriteLine("Do you go get some punch or stay with Daddy and Emmanuelle? (Type Punch or Stay)");
                    string choice22 = Console.ReadLine();

                    if (choice22 == "Punch" || choice22 == "punch")
                    {

                    }
                    else
                    {

                    }
                }
            }
        }
    }
    
}
