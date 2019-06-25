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
            Console.WriteLine("SETTING- It is a freezing winter night. You are in n old school that is now used by the dance crew you are in. The gym is where you perform and have " +
                              "the party and the old classrooms have been turned into individual dorm rooms.");
            Console.WriteLine("*DANCE MUSIC PLAYS IN THE BACKGROUND*");
            Console.WriteLine("*YOU WALK OUT ON THE DANCE FLOOR WITH THE REST OF THE DANCE CREW*");
            Console.WriteLine("*YOU PERFORM THE CHOREOGRAPHED DANCE*");
            Console.WriteLine("*SONG ENDS*");
            Console.WriteLine("EMMANUELLE (The Choreographer): Good job everyone! I am so happy to see all of " +
                              "your hard work starting to pay off! As you know we are heading to America " +
                              "tommorow and I couldn't be more proud to show the American audiences what French " +
                              "dancing is really about! Now I want you to all rest and have a good time before we " +
                              "head off tomorrow, I've made alcoholic punch and set out food. Also, our fellow dancer Daddy " +
                              "will be the DJ for tonight so if you want some good music make sure to kiss up to him. HAVE FUN!");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("Do you want to go hangout with your boyfriend David or go and hangout with Daddy the DJ? (TYPE: David or Daddy)");
            string choice1 = Console.ReadLine();

            if (choice1 == "David" || choice1 == "david")
            {
                Console.WriteLine("*YOU START TO WALK OVER TO DAVID BUT SEE HE IS FLIRTING WITH SOMEONE ELSE.");

                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine("Do you confront him or go to your friend Lou? (Type: David or Lou)");
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
                        Console.WriteLine("Do you take the cup or decline? (Type Take or Decline)");
                        string choice14 = Console.ReadLine();

                        if (choice14.ToLower() == "take") // drink the punch
                        {
                            Console.WriteLine("*YOU TAKE THE DRINK AND DOWN IN*");
                            Console.WriteLine("DAVID: That's my girl!");
                            Console.WriteLine("*DAVID TAKES YOU OUT TO DANCE*");
                            Console.WriteLine("*AS YOU AND DAVID DANCE IVANA BUMPS INTO YOU*");
                            Console.WriteLine("*SHE LOOKS SPACED OUT AND IS WOBBLING, SHE GRABS YOUR FACE AND CARESSES IT*");
                            Console.WriteLine("IVANA: You feel so nice.");
                            Console.WriteLine("*SHE STUMBLES AWAY TOWARDS THE PUNCH*");
                            Console.WriteLine("DAVID: Someone probably needs to stop her, she is too out of it.");

                            Console.WriteLine("---------------------------------------------------------------------------");
                            Console.WriteLine("Do you go check to see if she is ok or keep dancing? (Type: Check or Dance)");
                            string choice = Console.ReadLine();

                            if (choice.ToLower() == "check") //Check on Ivana
                            {

                            }
                            else // Keep Dancing
                            {

                            }
                        }

                        else //Dont drink the punch
                        {
                            Console.WriteLine("YOU: No thank you. I'm not thirsty right now.");
                            Console.WriteLine("DAVID: Wow, we have a goody goody here. Watch out or she'll steal all of the fun!");
                            Console.WriteLine("YOU: I might get some later, just not right now.");
                            Console.WriteLine("DAVID: I am going to see if Taylor wants some punch.");
                            Console.WriteLine("*DAVID POURS A CUP OF PUNCH AND LEAVES*");

                            Console.WriteLine("---------------------------------------------------------------------------");
                            Console.WriteLine("Do you head to bed or go and dance with Tito, Emmanuelle's son? (Type: Bed or Dance)");
                            string choice = Console.ReadLine();

                            if (choice.ToLower() == "bed")
                            {
                                Console.WriteLine("*YOU LEAVE THE PARTY, HEAD TO BED, AND GO TO SLEEP*");
                                Console.WriteLine("*YOU THEN WAKE UP TO YOUR FELLOW DANCERS PULLING YOU OUT OF BED WITH RAGE*");
                                Console.WriteLine("DAVID: SHE DIDN'T DRINK ANY OF IT!");
                                Console.WriteLine("DADDY: SHE MUST HAVE DONE IT");
                                Console.WriteLine("LEA: SHE DRUGGED US!");
                                Console.WriteLine("*THEY PULL YOU OUT OF THE BED AND START BEATING YOU UP*");
                                Console.WriteLine("*YOU DIE FROM HEAD TRAUMA AND LACK OF MEDICAL HELP*");
                            }
                            else
                            {
                                Console.WriteLine("*YOU LOOK FOR TITO IN THE CROWD*"); 
                                Console.WriteLine("*YOU SEE HE IS STANDING NEXT TO HIS MOTHER ACROSS THE ROOM*");
                                Console.WriteLine("*YOU START TO HEAD OVER WHEN YOU HEAR A THUMP BEHIND YOU*");
                                Console.WriteLine("*YOU SEE RILEY, A FELLOW CREW MEMBER, ON THE GROUND FREAKING OUT*");

                                Console.WriteLine("---------------------------------------------------------------------------");
                                Console.WriteLine("Do you help Riley or go tell Emmanuelle? (Type: Help or Emmanuelle)");
                                string choice = Console.ReadLine();

                                if (choice.ToLower () == "help")
                                {
                                    Console.WriteLine("*YOU RUSH OVER TO RILEY, HE IS CONVULSING*");
                                    Console.WriteLine("*YOU TRY TO HOLD HIM STILL BUT HE IS TOO STRONG*");
                                    Console.WriteLine("YOU: SOMEONE HELP!");
                                    Console.WriteLine("*OMAR RUSHES TO HELP TRY AND HOLD HIM DOWN*");
                                    Console.WriteLine("*EVERYONE ELSE JUST STANDS AND STARES*");
                                    Console.WriteLine("IVANA: He looks like he is on something.");
                                    Console.WriteLine("DADDY: He doesn't do drugs.);
                                    Console.WriteLine("LEA: I feel weird.");
                                    Console.WriteLine("IVANA: I feel high.");
                                    Console.WriteLine("EMMANUELLE: Me too!");
                                    Console.WriteLine("SILA: Someone must have spiked us something in the punch.");
                                    Console.WriteLine("DADDY: Who hasn't had anything to drink?");
                                    Console.WriteLine("DAVID: " + name + " hasn't!");
                                    Console.WriteLine("---------------------------------------------------------------------------");
                                    Console.WriteLine("THE NEXT DAY");
                                    Console.WriteLine("---------------------------------------------------------------------------");
                                    Console.WriteLine("*Refering to a body covered by two giant speakers*" );
                                    Console.WriteLine("Policewoman: We found her here, must've pulled them down while high and got crushed.");
                                    Console.WriteLine("YOU DIED");

                                }
                                else
                                {
                                    Console.WriteLine("*YOU RUN TOWARDS EMMANUELLE WHILE EVERYONE FLOCKS AROUND RILEY*");
                                    Console.WriteLine("YOU: Emmanuelle! Something is happening to Riley!");
                                    Console.WriteLine("*SHE LOOKS FATIGUED*");
                                    Console.WriteLine("EMMANUELLE: What?");
                                    Console.WriteLine("*YOU HEAR ACROSS THE ROOM*");
                                    Console.WriteLine("DAVID: ITS HER!");
                                    Console.WriteLine("*EVERYONE RUSHES TO YOU*");
                                    Console.WriteLine("LEA: WHAT DID YOU GIVE US!");
                                    Console.WriteLine("*THERE IS A CACOPHONY OF SOUNDS*");
                                    Console.WriteLine("SILA: SHE DID THIS TO US!");
                                    Console.WriteLine("*SILA DRAGS YOU OFF BY THE HAIR AS YOU KICK AND SCREAM*");
                                    Console.WriteLine("*PEOPLE YELL AT YOU KICKING AND SLAPPING YOU*");
                                    Console.WriteLine("*SILA DRAGS YOU TO THE DOUBLE DOORS THAT LEAD TO OUTSIDE AND THROWS YOU OUT INTO THE FREEZING COLD*");
                                    Console.WriteLine("*THEY CLOSE AND LOCK THE DOOR KEEPING YOU FROM ENTERING THE SCHOOL*");
                                    Console.WriteLine("*YOU DIE FROM FROSTBITE*");
                                }

                            }

                        }
                    }
                    else//Go talk to Emmanuelle
                    {
                        Console.WriteLine("YOU: No thank you.");
                        Console.WriteLine("*YOU WALK OVER TO DADDY THE DJ ON STAGE WHO IS HANGING OUT WITH THE CHOREOGRAPHER EMMANUELLE AND TITO (EMMANUELLE'S CHILD)*");
                        Console.WriteLine("EMMANUELLE: There is the shining star! You know I never have to ask you to bring your all, you never disappoint me on the dance floor!");
                        Console.WriteLine("YOU: Please keep praising me, I need the good vibes");
                        Console.WriteLine("EMMANUELLE: What's wrong?");
                        Console.WriteLine("YOU: I don't want to talk about it.");
                        Console.WriteLine("EMMANUELLE: I know what will cheer you up, go get some of my punch! It is my mothers recipe and it always seemed to cheer her up to the point she couldn't walk!");

                        Console.WriteLine("---------------------------------------------------------------------------");
                        Console.WriteLine("Do you go get some punch or stay with Daddy and Emmanuelle? (Type Punch or Stay)");
                        string choice15 = Console.ReadLine();

                        if (choice15 == "Punch" || choice15 == "punch")//get some punch
                        {
                            Console.WriteLine("YOU: Fine, but I expect this punch to be the best drink in my life!");
                            Console.WriteLine("*YOU WALK OVER TO THE PUNCH AND DAVID IS STANDING THERE DRINKING SOME");
                            Console.WriteLine("YOU: Seems you got bored flirting with one of those other girls.");
                            Console.WriteLine("DAVID: What are you talking about? Are you talking LEA? We were just talking I swear! There is no other girl but you!");
                            Console.WriteLine("*HE FIXES HIMSELF A CUP AND DRINKS IT IN ONE GULP, HE THEN MAKES ANOTHER CUP AND OFFERS IT TO YOU*");

                            Console.WriteLine("---------------------------------------------------------------------------");
                            Console.WriteLine("Do you take the cup or decline? (Type Take or Decline)");
                            string choice14 = Console.ReadLine();

                        }
                        else//stay with Emmanuelle
                        {
                            Console.WriteLine("YOU: I don't think a drink is going to lift my spirits.");
                            Console.WriteLine("DADDY: Then do it for me! I need my spirits lifted!");
                            Console.WriteLine("YOU: Fine! Only for you!");
                            Console.WriteLine("DADDY: That's my girl!");
                            Console.WriteLine("*YOU WALK OVER TO THE PUNCH AND DAVID IS THERE DRINKING SOME");
                            Console.WriteLine("YOU: Seems you got bored flirting with one of those other girls.");
                            Console.WriteLine("DAVID: What are you talking about? Are you talking LEA? We were just talking I swear! There is no other girl but you!");
                            Console.WriteLine("*HE FIXES HIMSELF A CUP AND DRINKS IT IN ONE GULP, HE THEN MAKES ANOTHER CUP AND OFFERS IT TO YOU*");

                            Console.WriteLine("---------------------------------------------------------------------------");
                            Console.WriteLine("Do you take the cup or decline? (Type Take or Decline)");
                            string choice14 = Console.ReadLine();

                        }
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
                    Console.WriteLine("Do you try lift Lou's spirit or go find David? (Type Lift Spirit or Find David");
                    string choice13 = Console.ReadLine();

                    if (choice13 == "Lift Spirit" || choice13 == "lift spirit")// lift Lou's spirit
                    {
                        Console.WriteLine("YOU: You know what, I'll go get you some water. Maybe you are dehydrated.");
                        Console.WriteLine("*YOU WALK OVER TO THE DRINKS AND DAVID IS STANDING THERE DRINKING SOME PUNCH");
                        Console.WriteLine("YOU: Seems you got bored flirting with one of those other girls.");
                        Console.WriteLine("DAVID: What are you talking about? Are you talking LEA? We were just talking I swear! There is no other girl but you!");
                        Console.WriteLine("*HE FIXES HIMSELF A CUP AND DRINKS IT IN ONE GULP, HE THEN MAKES ANOTHER CUP AND OFFERS IT TO YOU*");

                        Console.WriteLine("---------------------------------------------------------------------------");
                        Console.WriteLine("Do you take the cup or decline? (Type Take or Decline)");
                        string choice14 = Console.ReadLine();
                    }
                    else //Go find  David
                    {
                        Console.WriteLine("YOU: Ok, I'll give you some space");
                        Console.WriteLine("*YOU GO AND SEE THAT DAVID IS BY THE PUNCH, YOU WALK UP TO HIM*");
                        Console.WriteLine("YOU: If I see you flirting with another girl again, I will personally kill you.");
                        Console.WriteLine("DAVID: I don't know what you are talking about, but ok.");
                        Console.WriteLine("*HE LAUGHS AND FIXES HIMSELF A CUP OF PUNCH DRINKING IT IN ONE GULP, HE THEN MAKES ANOTHER CUP AND OFFERS IT TO YOU*");

                        Console.WriteLine("---------------------------------------------------------------------------");
                        Console.WriteLine("Do you take the cup or decline? (Type Take or Decline)");
                        string choice14 = Console.ReadLine();
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
                        Console.WriteLine("*YOU GIVE THEM SOME WEED OUT OF YOUR POCKET TRYING NOT TO LET TITO SEE*");
                        Console.WriteLine("IVANA: Only weed? I want something stronger! I only have a little bit left of my personal stash and I'm only using it for a special occasion!");
                        Console.WriteLine("*IVANA AND PSYCHE START WALKING TOWARDS THE HALLWAY WITH THE ROOMS*");
                        Console.WriteLine("*YOU DRAG TITO AND START DANCING WITH HIM ON THE DANCE FLOOR, WHEN OMAR BUMPS INTO YOU.");
                        Console.WriteLine("*YOU SEE OMAR IS SWEATING LIKE CRAZY*");
                        Console.WriteLine("YOU: Omar, you look a little hot, need me to get you some punch?");
                        Console.WriteLine("OMAR: No thank you I don't drink alcochol, especially that punch. Who knows what all Emmanuelle put in it. But I wouldn't mind some water if you are going over there.");
                        Console.WriteLine("YOU: Hey Tito, go back to your mom, I am going to head over and get something to drink.");
                        Console.WriteLine("*YOU WATCH TITO GO OVER TO EMMANUELLE AND THEN WALK OVER TO THE DRINK STATION AND DAVID IS STANDING GETTING HIMSELF A CUP*");
                        Console.WriteLine("DAVID: Hey babe! How are you?");
                        Console.WriteLine("YOU: I'm pretty good, a little tired, who knew Tito was such a good dancer!");
                        Console.WriteLine("*DAVID TAKES A CUP OF THE PUNCH AND DOWNS IT FAST, HE THEN POURS ANOTHER CUP AND OFFERS IT TO YOU*");
                        Console.WriteLine("DAVID: Here, this will liven you up a bit!");

                        Console.WriteLine("---------------------------------------------------------------------------");
                        Console.WriteLine("Do you take the cup or decline? (Type Take or Decline)");
                        string choice14 = Console.ReadLine();

                    }
                    else // Lie about the weed
                    {
                        Console.WriteLine("You: Sorry, I'm out. I'd check Elise, she is always on something. She'll hook you two up.");
                        Console.WriteLine("PSYCHE: Not me, after seeing my roommate drip stuff in her eyes for a high I knew I had to get out of there.");
                        Console.WriteLine("IVANA: She is over exaggerating, don't listen to her.");
                        Console.WriteLine("PSYCHE: I am not! You always do this.");
                        Console.WriteLine("IVANA: Do what? Tell the truth?");
                        Console.WriteLine("*AS THEY BICKER YOU TELL TITO TO GO BACK TO EMMANUELLE*");
                        Console.WriteLine("*YOU WATCH TITO GO OVER TO EMMANUELLE AND THEN WALK OVER TO THE DRINK STATION AND DAVID IS STANDING GETTING HIMSELF A CUP*");
                        Console.WriteLine("DAVID: Hey babe! How are you?");
                        Console.WriteLine("YOU: I'm pretty good, just heard another one of the famous Ivana/Psyche fights.");
                        Console.WriteLine("*DAVID TAKES A CUP OF THE PUNCH AND DOWNS IT FAST, HE THEN POURS ANOTHER CUP AND OFFERS IT TO YOU*");
                        Console.WriteLine("DAVID: Here, this will make you forget that!");

                        Console.WriteLine("---------------------------------------------------------------------------");
                        Console.WriteLine("Do you take the cup or decline? (Type Take or Decline)");
                        string choice14 = Console.ReadLine();

                    }
                }
                else // Talk to Emmanuelle and Daddy
                {
                    Console.WriteLine("*YOU WALK UP TO EMMANUELLE AND HUG HER FROM BEHIND*");
                    Console.WriteLine("YOU: How was it really?");
                    Console.WriteLine("EMMANUELLE: AMAZING! I really couldn't be more proud.");
                    Console.WriteLine("YOU: I am honestly still so nervous.");
                    Console.WriteLine("EMMANUELLE: You are doing amazing! Give yourself a break and let loose a little. Go have some punch!");

                    Console.WriteLine("---------------------------------------------------------------------------");
                    Console.WriteLine("Do you go get some punch or stay with Daddy and Emmanuelle? (Type Punch or Stay)");
                    string choice22 = Console.ReadLine();

                    if (choice22 == "Punch" || choice22 == "punch")//Go to the Punch
                    {
                        Console.WriteLine("YOU: Ok! Ok! I'll go and get some of your stupid punch.");
                        Console.WriteLine("DADDY: It is delicious!");
                        Console.WriteLine("*YOU WALK OVER TO THE PUNCH AND DAVID IS STANDING THERE*");
                        Console.WriteLine("DAVID: Hey babe! How are you?");
                        Console.WriteLine("YOU: Trying to have fun. I am honestly just so nervous about America.");
                        Console.WriteLine("*DAVID TAKES A CUP OF THE PUCNCH AND DOWNS IT FAST, HE THEN POURS ANOTHER CUP AND OFFERS IT TO YOU");
                        Console.WriteLine("DAVID: Here, this will loosen you up a bit!");

                        Console.WriteLine("---------------------------------------------------------------------------");
                        Console.WriteLine("Do you take the cup or decline? (Type Take or Decline)");
                        string choice14 = Console.ReadLine();
                    }
                    else//Decline the punch
                    {
                        Console.WriteLine("YOU: No thank you. I don't want anything to drink right now.");
                        Console.WriteLine("DADDY: Well I want some, go and get me some before I die of thirst.");
                        Console.WriteLine("YOU: Fine, but only for you!");
                        Console.WriteLine("DADDY: Thank you!");
                        Console.WriteLine("*YOU WALK OVER TO THE DRINK STATION AND DAVID IS STANDING GETTING HIMSELF A CUP*");
                        Console.WriteLine("DAVID: Hey babe! How are you?");
                        Console.WriteLine("YOU: Trying to have fun. I am honestly just so nervous about America.");
                        Console.WriteLine("*DAVID TAKES A CUP OF THE PUNCH AND DOWNS IT FAST, HE THEN POURS ANOTHER CUP AND OFFERS IT TO YOU*");
                        Console.WriteLine("DAVID: Here, this will loosen you up a bit!");

                        Console.WriteLine("---------------------------------------------------------------------------");
                        Console.WriteLine("Do you take the cup or decline? (Type Take or Decline)");
                        string choice14 = Console.ReadLine();
                    }
                }
            }
        }
    }
    
}