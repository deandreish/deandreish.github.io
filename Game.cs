using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    public class Game
    {
        //Dream Plauges is a game where the player will be forced to face their fears and trust their guts to make out of the castle or at least one level of the castle.
        //Here you will choose on what path to take and gathher information on what is excatly going on in this world. Paths will lead to inevitably the same place but who you end up with or what you learned is also different for each path!
        // Code that was used was mostly from following PrgrammingisFun website and google and youtube...lots of youtube.(http://programmingisfun.com/
        //You will enconter an Ogre/demon/And a ghostly woman on your travels and its up to you on how you deal with them...or they lead you to destructuion but tis okay life is full of complicated choices.
        //Your personal fear will be remembered and used agianst you as well.
        //Int variable is just for fun like demon trope with the "666"
        //Tons of string varibales that make the player feel like they are there for instance their name is refrenced and their fears are tracked so its some sort of unique to them.









        //Players fear taken down and refrenced later in the game
        public static Player CurrentPlayer { get; set; } = new Player();



        // Lord dark keeps castle Ascii Art(https://www.asciiart.eu/buildings-and-places/castles)
        // AsciiArt by ejm (https://ascii.co.uk/art/doors)

        //Code used here was with thhe help of programming is fun
        //Start the game and start the first choice
        public static void Start()
        {


            Console.WriteLine(@"
 ___                                     ___   _                               
(  _`\                                  (  _`\(_ )                             
| | ) | _ __   __     _ _   ___ ___     | |_) )| |    _ _  _   _    __     __  
| | | )( '__)/'__`\ /'_` )/' _ ` _ `\   | ,__/'| |  /'_` )( ) ( ) /'_ `\ /'__`\
| |_) || |  (  ___/( (_| || ( ) ( ) |   | |    | | ( (_| || (_) |( (_) |(  ___/
(____/'(_)  `\____)`\__,_)(_) (_) (_)   (_)   (___)`\__,_)`\___/'`\__  |`\____)
                                                                 ( )_) |       
                                                                  \___/'       
");

            Console.WriteLine(@"                                                       
  |  |                                                      |  |
 /----\                        
 |    |         _____                        _____         |    |
 |[]  |        [     ]                      [     ]        |  []|
 |    |       [_______][ ][ ][ ][][ ][ ][ ][_______]       |    |
 |    [ ][ ][ ]|     |  ,----------------,  |     |[ ][ ][ ]    |
 |             |     |/'    ____..____    '\|     |             |
  \  []        |     |    /'    ||    '\    |     |        []  /
   |      []   |     |   |o     ||     o|   |     |  []       |
   |           |  _  |   |     _||_     |   |  _  |           |
   |   []      | (_) |   |    (_||_)    |   | (_) |       []  |
   |           |     |   |     (||)     |   |     |           |
   |           |     |   |      ||      |   |     |           |
 /''           |     |   |o     ||     o|   |     |           ''\
[_____________[_______]--'------''------'--[_______]_____________]");




            Console.WriteLine();
            Console.WriteLine("Fight your way to the top of this demented castle, hard choices and and death await!");
            string CharacterName = "random";
            int Numbersoul = 666;
            Console.WriteLine("Face your fears!");
            Console.WriteLine("What would you like your character's name to be?");
            CharacterName = Console.ReadLine();
            Console.WriteLine("what is your fear?");
            CurrentPlayer.Fear = Console.ReadLine();
            Console.WriteLine($" {CurrentPlayer.Fear},The castle will rememeber that....");

            Console.WriteLine(" you are the " + Numbersoul + "th soul to enter here...");



            Console.WriteLine("Your character is now named " + CharacterName + " Good luck!");
            Console.WriteLine("FULL SCREEN MODE RECOMMENED THANK YOU.");
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("you awaken to a damp cold dungeon...");
            Console.WriteLine(" You head up the first set of stairs");
            Console.ResetColor();

            Console.WriteLine("You see 2 ways to go. You hear mechanical noises on the left and you hear screams to the right?");

            Choice();

        }


        // AsciiArt by ejm (https://ascii.co.uk/art/doors)
        //Choice leads to player finding the demon or woman and getting different parts of the story to put together in mutiple playthroughs
        static void Choice()

        {


            string input = "";
            Console.WriteLine("Press 1 to go right or 2 to go left");
            input = Console.ReadLine();
            if (input == "1")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You chose to go right..");
                Console.ResetColor();
                Console.WriteLine(" Choosing to go towards the screams you find an old decrepted demon and they ask you to come closer");

                Console.WriteLine(@" 
                    ==========+ 
                    |  __  __  ||       
                    | |  ||  | ||
                    | |  ||  | ||
                    | |__||__| |--
                    |  __  __()|\ 
                    | |  ||  | +|
                    | |  ||  | ||
                    | |  ||  | ||
                    | |__||__| ||
                    |__________|-             ");

                DialogA();





            }
            else if
            (input == "2")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You chose to go left...");
                Console.ResetColor();
                Console.WriteLine(" Choosing to go towards the mechenical noises you see a woman silently sobbing asking for whoever is out there for help");
                Console.WriteLine(@" 
                    ==========+ 
                    |  __  __  ||       
                    | |  ||  | ||
                    | |  ||  | ||
                    | |__||__| |--
                    |  __  __()|\ 
                    | |  ||  | +|
                    | |  ||  | ||
                    | |  ||  | ||
                    | |__||__| ||
                    |__________|-             ");
                DialogB();

            }
            else
            {
                Console.WriteLine("you must choose...");

                Choice();


            }

        }




        //Player chooses to go o talk with the demon and getting random password but still able to change choices before commiting to path
        // Ascii Art by snafu(https://asciiart.website/index.php?art=creatures/monsters)
        static void DialogA()
        {

            static void password()
            {

                Random r = new Random();

                string[] passwords = { "DEMON", "HELL", "ARRAY", "PIT" };

                Console.WriteLine(passwords[r.Next(0, passwords.Length)]);

            }


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Demon:  Ahh did you hear screams? They echo through out this deformed castle.... you must be one of the new ones yes? do you know where you are? you are in a hell among hells. Nothing here is your friend, why accept me of course.");
            Console.WriteLine();
            Console.WriteLine("Demon: Dont worry I will not lead you astray in fact I feel like helping you...that of course if you want it?");
            Console.WriteLine(@"                      
    .K                       Z.
    jM.                     .Mk
    WMk                     jMW
    YMM.       ,,,,,,      .MMY
    `MML;:''```      ```':;JMM'
    /`JMMMk.           .jMMMk'\
    / `GMMMI'         `IMMMO' \
   /    ~~~'           `~~~    \
   /                           \
   |                           |
   |      ;,           ,;      |
   |      Tk           jT      |
    |     `Mk   . .   jM'     |
    |      YK.   Y   .ZY      |
     \     `Kk   |   jZ'     /
     \       `'  |  `'       /
      \          |          /
       \         |         /
       \         |         /
        \        |        /
         \       |       /
         \       |       /
          \      |      /
           \     |     /
           \  |  |  |  /
            \ {| | |} /
             \ ` | ' /
              \  |  /
              \  |  /
               \   /
                \ /
                 ~  ");






            Console.ResetColor();
            string input = "";
            Console.WriteLine("Press 1 for yes OR 2 for no I dont trust you");
            input = Console.ReadLine();
            if (input == "1")
            {

                Console.WriteLine("You chose to ask for help..");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(" Yes id like help");
                Console.ResetColor();


                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Demon:Goood.... Im glad you asked... all you will need at least for a small part of your journey is a word and that word is... ");
                Console.WriteLine();
                password();
                Console.WriteLine("Demon: Id remember that word if I was you.");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You take what was given and leave the the room with the demon grinning uncomfortably at you.You feel weird but at least you got out of that creepy area.");
                Console.ResetColor();


                ChoiceA();




            }
            else if (input == "2")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("You chose to deny help..");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(" No! why would I trust you!?");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Demon: Fine! see how far you get without my help hahahahhah!");
                Console.ResetColor();
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("you leave the room in a hurry back to the hallway you came from....");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Now where?");
                Console.ResetColor();
                Choice();
            }

            else
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("you must choose...");
                Console.ResetColor();


                DialogA();


            }











        }




        //Player chooses to go o talk with the woman and getting lore on where they are but still able to change choices before commiting to path.
        //Ascii art by alyssa(https://ascii.co.uk/art/women)
        static void DialogB()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Woman:Please help me.... I woke up tied to this machine and I cannot escape.... Its so quiet...always so quiet");
            Console.ResetColor();
            Console.WriteLine(@"     _____
                       /     \
                      / ````` \
                     /|`o   o'|\
                    /||   .   ||\
                    |*\\  _  //*|
                    |*/ \   / \*|
                    //  /   \  \\
                   /(__/\___/\__)\
                   |             |
                   |  |       |  |
                   |  |       |  |
                   |  |       |  |
                   |  |\     /|  |
                   /  //     \|  |
                  /  //       |  |
                 /  / |       |  |
                /___\ |       |___\
               / /    |       | |
              /  \    |       /  \
             //^`,    |       |  |
            //        |       |~~
                      |       |
                      |       |
                      |       |
                      |       |
                      |       |
                      |       |
                     /         \
                    /           \
                   /             \   ");







            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("you inspect the machhine and see a hughe plug behind it....youre not sure of the outcome....");
            Console.ResetColor();
            string input = "";
            Console.WriteLine("Press 1) to free her. press 2) to leave");
            input = Console.ReadLine();
            if (input == "1")
            {

                Console.WriteLine("You chose to help her..");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(" you pull aggresively on the machhines plug and sparks fly....");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Woman:thank you for freeing me...I cant give you anything but this information I overheard from thhese things here...");
                Console.WriteLine("The woman is a ghost of some sort, she seems happy to be free but looks sad for me.");
                Console.WriteLine("Woman: dont trust the old demon down the hallway, he is known for playing tricks on...new prey so to speak.");
                Console.ResetColor();
                Console.WriteLine();

                ChoiceB();





            }
            else if (input == "2")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("You chose to not help..");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" You are too freaked out to listen to anymore of what she has to say and you run back in the hallway.?");
                Console.WriteLine("Now where?");
                Choice();
            }

            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("you must choose...");
                Console.ResetColor();


                DialogB();





            }










        }


        //if player commits to demon path they meet their fears/the ogre guarding the door waiting for password or death.
        static void ChoiceA()

        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" You exit the Hallway to see the previous path is no longer there yet you see a new door that wasn't there before...");
            Console.WriteLine("you go through.....");
            Console.WriteLine(@"  ______________
                                |\ ___________ /|
                                | |  /|,| |   | |
                                | | |,x,| |   | |
                                | | |,x,' |   | |
                                | | |,x   ,   | |
                                | | |/    |%==| |
                                | |    /] ,   | |
                                | |   [/ ()   | |
                                | |       |   | |
                                | |       |   | |
                                | |       |   | |
                                | |      ,'   | |
                                | |   ,'      | |
                                |_|,'_________|_|");


            Console.WriteLine($"Suddenly the door slams and you are trapped and you feel trapped! You begin to be swarmed by {CurrentPlayer.Fear}!  ");
            Console.WriteLine(" What are you going to do?");
            Console.ResetColor();

            string input = "";
            Console.WriteLine("Press 1 to Run away to find cover!) or Press 2 to Stay in the swarm!)");
            input = Console.ReadLine();
            if (input == "1")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" You Decided to run...");
                Console.WriteLine();
                Console.WriteLine($" You run and find a nerby door. You slam the door and hide and wait for the swarm of {CurrentPlayer.Fear} to pass by.  ");
                Console.WriteLine(" You hear nothing....");
                Console.WriteLine($"Suddenly the door is pushed open wide and you are engulfed in {CurrentPlayer.Fear}, no where to run, no where to hide just empty....");
                Console.WriteLine(" You have perished....");
                Console.WriteLine(@"_                   _
                                     _( )                 ( )_
                                    (_, |      __ __      | ,_)
                                       \'\    /  ^  \    /'/
                                        '\'\,/\      \,/'/'
                                          '\| []   [] |/'
                                            (_  /^\  _)
                                              \  ~  /
                                              /HHHHH\
                                            /'/{^^^}\'\
                                        _,/'/'  ^^^  '\'\,_
                                       (_, |           | ,_)
                                         (_)           (_)");


                Console.ResetColor();

                CheckpointA();




            }
            else if
            (input == "2")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You chose to face your Fear");
                Console.ResetColor();

                Console.WriteLine($"As you are stand in the {CurrentPlayer.Fear} You dont feel any pain yet you still feel uneasy.");
                Console.WriteLine(" The swarm disapears but something menacing takes its place. Something Big.");
               

                Ogre Thor = new Ogre("Thor", "Bloodreach");
                Thor.Meet();
                password();

            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("you must choose...");
                Console.ResetColor();

                ChoiceA();


            }

        }




        //Player gives paswords and reaches stalemate if password is not given. Closere to demon path ending
        //Asciiart byS.C.E.S.W.(https://asciiart.website/index.php?art=creatures/monsters)
        static void password()

        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" What was the word the demon said again?");

            string input = "";
            input = Console.ReadLine();
            input = input.ToUpper();
            if (input == "DEMON")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" Ogre: correct...I never met someone wwho wanted to go in here before tho hehehehh");
                Console.ResetColor();


                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" The Ogre picks me up and throws me in the mysterious door way");
                Console.WriteLine(" You dont lke this place ..its cold... ther also seems to be a foul odor in front of you.");
                Console.WriteLine(" The source of the smell is the beast that emerges from the shadow...I see the bones of others laying before me, i think Ive been tricked by the old demon from earlier!");
                Console.WriteLine("I was set up to be dinner....");


                Console.WriteLine(@"######################~~..'|.##############.|`..~~#######################
##############~./`.~~./' ./ ################ \. `\. ~~.`\.~##############
############~.' `.`-'   /   ~#############~ .  \   `-'.'  `.~############
##########~.'    |     |  .'\ ~##########~ /`.  |     |     `.~##########
########~.'      |     |  |`.`._ ~####~ _.'.'|  |     |       `.~########
######~.'        `.    |  `..`._|\.--./|_.'..'  |    .'         `.~######
####~.'            \   | #.`.`._`.'--`.'_.'.'.# |   /             `.~####
##~.'       ......  \  | ###.`~'(o\||/o)`~'.### |  /  ......        `.~##
~.`.......'~      `. \  \~####  |\_  _/|  ####~/  / .'      ~`........'.~
;.'                 \ .----.__.'`(n||n)'`.__.----. /                  `;
`.                  .'    .'   `. \`'/ .'   `.    `.                  .'
#:               ..':      :    '. ~~ .`    :      :`..               :#
#:             .'   :     .'     .'  `.     `.     :   `.             :#
#:           .'    .`   .'       . || .       `.   '.    `.           :#
#:         .'    .' :       ....'      `....       : `.    `.         :#
#:       .'    .' ) )        (      )     (      (    )`.    `.       :#
#:     ..'    .  ( ((   )  ) )) (  ((  (  ))  )  ))  ((  `.   `..     :#
#:  ..'      .'# ) ) ) (( ( ( (  ) ) ) ))( ( (( ( (  ) ) #`.     `..  :#
#;.'        .'##|((  ( ) ) ) ) )( (  (( ( ) )) ) ) )( (||##`.       `.:#
#`.        .'###|\__  )( (( ( ( )  )  )) )  (  (( ( )_)/|###`.       .'#
##.`       '#####\__~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~__/#####`      '.##
###        #######  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~  #######       ###");






                Console.ResetColor();
                EndA();
                
            }
            else if
            (input == "HELL")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" Ogre: correct...I never met someone who wanted to go in here before tho hehehehh");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" The Ogre picks me up and throws me in the mysterious door way");
                Console.WriteLine(" You dont lke this place ..its cold... ther also seems to be a foul odor in front of you.");
                Console.WriteLine(" The source of the smell is the beast that emerges from the shadow...I see the bones of others laying before me, i think Ive been tricked by the old demon from earlier!");
                Console.WriteLine("I was set up to be dinner....");


                Console.WriteLine(@"######################~~..'|.##############.|`..~~#######################
##############~./`.~~./' ./ ################ \. `\. ~~.`\.~##############
############~.' `.`-'   /   ~#############~ .  \   `-'.'  `.~############
##########~.'    |     |  .'\ ~##########~ /`.  |     |     `.~##########
########~.'      |     |  |`.`._ ~####~ _.'.'|  |     |       `.~########
######~.'        `.    |  `..`._|\.--./|_.'..'  |    .'         `.~######
####~.'            \   | #.`.`._`.'--`.'_.'.'.# |   /             `.~####
##~.'       ......  \  | ###.`~'(o\||/o)`~'.### |  /  ......        `.~##
~.`.......'~      `. \  \~####  |\_  _/|  ####~/  / .'      ~`........'.~
;.'                 \ .----.__.'`(n||n)'`.__.----. /                  `;
`.                  .'    .'   `. \`'/ .'   `.    `.                  .'
#:               ..':      :    '. ~~ .`    :      :`..               :#
#:             .'   :     .'     .'  `.     `.     :   `.             :#
#:           .'    .`   .'       . || .       `.   '.    `.           :#
#:         .'    .' :       ....'      `....       : `.    `.         :#
#:       .'    .' ) )        (      )     (      (    )`.    `.       :#
#:     ..'    .  ( ((   )  ) )) (  ((  (  ))  )  ))  ((  `.   `..     :#
#:  ..'      .'# ) ) ) (( ( ( (  ) ) ) ))( ( (( ( (  ) ) #`.     `..  :#
#;.'        .'##|((  ( ) ) ) ) )( (  (( ( ) )) ) ) )( (||##`.       `.:#
#`.        .'###|\__  )( (( ( ( )  )  )) )  (  (( ( )_)/|###`.       .'#
##.`       '#####\__~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~__/#####`      '.##
###        #######  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~  #######       ###");








                Console.ResetColor();

                EndA();
                


            }
            else if
             (input == "ARRAY")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" Ogre: correct...I never met someone who wanted to go in here before tho hehehehh");
                Console.ResetColor();


                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" The Ogre picks me up and throws me in the mysterious door way");
                Console.WriteLine(" You dont lke this place ..its cold... ther also seems to be a foul odor in front of you.");
                Console.WriteLine(" The source of the smell is the beast that emerges from the shadow...I see the bones of others laying before me, i think Ive been tricked by the old demon from earlier!");
                Console.WriteLine("I was set up to be dinner....");

                Console.WriteLine(@"######################~~..'|.##############.|`..~~#######################
##############~./`.~~./' ./ ################ \. `\. ~~.`\.~##############
############~.' `.`-'   /   ~#############~ .  \   `-'.'  `.~############
##########~.'    |     |  .'\ ~##########~ /`.  |     |     `.~##########
########~.'      |     |  |`.`._ ~####~ _.'.'|  |     |       `.~########
######~.'        `.    |  `..`._|\.--./|_.'..'  |    .'         `.~######
####~.'            \   | #.`.`._`.'--`.'_.'.'.# |   /             `.~####
##~.'       ......  \  | ###.`~'(o\||/o)`~'.### |  /  ......        `.~##
~.`.......'~      `. \  \~####  |\_  _/|  ####~/  / .'      ~`........'.~
;.'                 \ .----.__.'`(n||n)'`.__.----. /                  `;
`.                  .'    .'   `. \`'/ .'   `.    `.                  .'
#:               ..':      :    '. ~~ .`    :      :`..               :#
#:             .'   :     .'     .'  `.     `.     :   `.             :#
#:           .'    .`   .'       . || .       `.   '.    `.           :#
#:         .'    .' :       ....'      `....       : `.    `.         :#
#:       .'    .' ) )        (      )     (      (    )`.    `.       :#
#:     ..'    .  ( ((   )  ) )) (  ((  (  ))  )  ))  ((  `.   `..     :#
#:  ..'      .'# ) ) ) (( ( ( (  ) ) ) ))( ( (( ( (  ) ) #`.     `..  :#
#;.'        .'##|((  ( ) ) ) ) )( (  (( ( ) )) ) ) )( (||##`.       `.:#
#`.        .'###|\__  )( (( ( ( )  )  )) )  (  (( ( )_)/|###`.       .'#
##.`       '#####\__~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~__/#####`      '.##
###        #######  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~  #######       ###");





                Console.ResetColor();
                EndA();
                



            }
            else if
           (input == "PIT")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" Ogre: correct...I never met someone who wanted to go in here before tho hehehehh");
                Console.ResetColor();


                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" The Ogre picks me up and throws me in the mysterious door way");
                Console.WriteLine(" You dont lke this place ..its cold... ther also seems to be a foul odor in front of you.");
                Console.WriteLine(" The source of the smell is the beast that emerges from the shadow...I see the bones of others laying before me, i think Ive been tricked by the old demon from earlier!");
                Console.WriteLine("I was set up to be dinner....");


                Console.WriteLine(@"######################~~..'|.##############.|`..~~#######################
##############~./`.~~./' ./ ################ \. `\. ~~.`\.~##############
############~.' `.`-'   /   ~#############~ .  \   `-'.'  `.~############
##########~.'    |     |  .'\ ~##########~ /`.  |     |     `.~##########
########~.'      |     |  |`.`._ ~####~ _.'.'|  |     |       `.~########
######~.'        `.    |  `..`._|\.--./|_.'..'  |    .'         `.~######
####~.'            \   | #.`.`._`.'--`.'_.'.'.# |   /             `.~####
##~.'       ......  \  | ###.`~'(o\||/o)`~'.### |  /  ......        `.~##
~.`.......'~      `. \  \~####  |\_  _/|  ####~/  / .'      ~`........'.~
;.'                 \ .----.__.'`(n||n)'`.__.----. /                  `;
`.                  .'    .'   `. \`'/ .'   `.    `.                  .'
#:               ..':      :    '. ~~ .`    :      :`..               :#
#:             .'   :     .'     .'  `.     `.     :   `.             :#
#:           .'    .`   .'       . || .       `.   '.    `.           :#
#:         .'    .' :       ....'      `....       : `.    `.         :#
#:       .'    .' ) )        (      )     (      (    )`.    `.       :#
#:     ..'    .  ( ((   )  ) )) (  ((  (  ))  )  ))  ((  `.   `..     :#
#:  ..'      .'# ) ) ) (( ( ( (  ) ) ) ))( ( (( ( (  ) ) #`.     `..  :#
#;.'        .'##|((  ( ) ) ) ) )( (  (( ( ) )) ) ) )( (||##`.       `.:#
#`.        .'###|\__  )( (( ( ( )  )  )) )  (  (( ( )_)/|###`.       .'#
##.`       '#####\__~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~__/#####`      '.##
###        #######  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~  #######       ###");










                Console.ResetColor();
                EndA();
                


            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" Ogre: were gonna be here a while arent we? I get VERY Hungry just so you know...");
                Console.ResetColor();
                password();

            }

        }



        //If player dies they can choose to continue from choice they left off from or end game.
        static void CheckpointA()

        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" would you Like to restart from checkpoint?");
            string input = "";
            Console.WriteLine("Press 1 for Yes) or Press 2 for No.)");
            input = Console.ReadLine();
            if (input == "1")
            {

                ChoiceA();



            }
            else if
            (input == "2")
            {
                Console.WriteLine("Thank you for playing!");
                Console.ReadKey();
                System.Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Please choose.");

                CheckpointA();


            }

        }



        //if player decides to save with the ghost woman and is able to ask questions for lore about castle /leave woman and continue on their own.
        static void ChoiceB()
        {
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" I leave the area with the ghostyl Woman by my side.");
            Console.WriteLine();
            Console.WriteLine(" The other path that as here before is no gone but a strange door is now here.");
            Console.WriteLine(@"  ______________
                                |\ ___________ /|
                                | |  /|,| |   | |
                                | | |,x,| |   | |
                                | | |,x,' |   | |
                                | | |,x   ,   | |
                                | | |/    |%==| |
                                | |    /] ,   | |
                                | |   [/ ()   | |
                                | |       |   | |
                                | |       |   | |
                                | |       |   | |
                                | |      ,'   | |
                                | |   ,'      | |
                                |_|,'_________|_|");



            Console.ResetColor();


            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(" Woman: Please dont go through that door! Every time I hear it open all i hear are screams...even the machine I am hooked up to isnt loud enough to cover it up.");
            Console.ResetColor();
            Console.WriteLine();


            Console.ForegroundColor = ConsoleColor.Yellow;
            string input = "";
            Console.WriteLine("Press 1 for, Can you explain whats going on?) or Press 2 for, How do you even know so much being trapped to a machine?.) Or 3, I do what I want");
            Console.ResetColor();
            input = Console.ReadLine();
            if (input == "1")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("What is going on here?");
                Console.ResetColor();
                Abby Abby = new Abby("Abby", "Ghost");
                Abby.Greet();
                Console.WriteLine();
                Anythingelse();


            }
            else if
            (input == "2")
            {
                Abby Abby = new Abby("Abby", "Ghost");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("How do you know so much?");
                Console.ResetColor();
                Abby.Info();
                Console.WriteLine();
                Anythingelse();

            }
            else if
             (input == "3")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("I helped you but that doesnt mean you can follow me!");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" you chose to leave The Woman behind and go through the door.");
                Console.ResetColor();
                Leavewoman();

            }
            else
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine(" I have no Idea what that means Im sorry....");
                Console.ResetColor();
                ChoiceB();

            }

        }


        //If player asked one question they are able to answer another or leave back to choices with ghost woman.
        static void Anythingelse()

        {

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Abby: Anything else?");
            string input = "";
            Console.WriteLine("Press 1 for Yes) or Press 2 for No.)");
            input = Console.ReadLine();
            if (input == "1")
            {

                ChoiceB();



            }
            else if
            (input == "2")
            {
                Continued();

            }
            else
            {

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Abby: I dont understand?");
                Anythingelse();




            }



        }




        //Player stays with the ghost and reaches the end of ghost woman path
        //Asciiart byS.C.E.S.W.(https://asciiart.website/index.php?art=creatures/monsters)
        static void Continued()
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("I accept the answers I was given and ponder what to do next.");
            Console.WriteLine();
            Console.WriteLine(" All of A sudden this giant Ogre Bust through the door!");
            Console.ResetColor();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" Ogre: I was promised food for my pet! He promised to send!!! Where are you little ones!?");
            Console.WriteLine(" Ogre: Ahhh there you are!");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" The ogre grabs me and walks me to a door and throws me in.");
            Console.WriteLine(" Abby flies in the room through the door and ask if I am okay");
            Console.WriteLine(" The room is dark but I hear a low growl in front of me. There is a beast..it looks at me with hunger in its eyes...");
            Console.WriteLine(" Im its dinner...");

            Console.WriteLine(@"######################~~..'|.##############.|`..~~#######################
##############~./`.~~./' ./ ################ \. `\. ~~.`\.~##############
############~.' `.`-'   /   ~#############~ .  \   `-'.'  `.~############
##########~.'    |     |  .'\ ~##########~ /`.  |     |     `.~##########
########~.'      |     |  |`.`._ ~####~ _.'.'|  |     |       `.~########
######~.'        `.    |  `..`._|\.--./|_.'..'  |    .'         `.~######
####~.'            \   | #.`.`._`.'--`.'_.'.'.# |   /             `.~####
##~.'       ......  \  | ###.`~'(o\||/o)`~'.### |  /  ......        `.~##
~.`.......'~      `. \  \~####  |\_  _/|  ####~/  / .'      ~`........'.~
;.'                 \ .----.__.'`(n||n)'`.__.----. /                  `;
`.                  .'    .'   `. \`'/ .'   `.    `.                  .'
#:               ..':      :    '. ~~ .`    :      :`..               :#
#:             .'   :     .'     .'  `.     `.     :   `.             :#
#:           .'    .`   .'       . || .       `.   '.    `.           :#
#:         .'    .' :       ....'      `....       : `.    `.         :#
#:       .'    .' ) )        (      )     (      (    )`.    `.       :#
#:     ..'    .  ( ((   )  ) )) (  ((  (  ))  )  ))  ((  `.   `..     :#
#:  ..'      .'# ) ) ) (( ( ( (  ) ) ) ))( ( (( ( (  ) ) #`.     `..  :#
#;.'        .'##|((  ( ) ) ) ) )( (  (( ( ) )) ) ) )( (||##`.       `.:#
#`.        .'###|\__  )( (( ( ( )  )  )) )  (  (( ( )_)/|###`.       .'#
##.`       '#####\__~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~__/#####`      '.##
###        #######  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~  #######       ###");

            EndB();


        }


        //More detail of ghost woman ending
        static void EndB()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($" Standing there with Abby the creature takes on a form of {CurrentPlayer.Fear} and begins to walk slowly toward you.");
            Console.WriteLine();
            Console.WriteLine(" You're scared but having someone with you will make the fear easier to get through. The choices you made to get to this ending shows you are on a path to facing greater fear and in this you feel confident to take on this challenge..");
            Console.WriteLine();
            
            Console.WriteLine("End of level one.");
            Console.ReadKey();
            System.Environment.Exit(0);


        }


        //More detail of demon ending
        static void EndA()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($" Standing therethe creature  begins to take on a form of {CurrentPlayer.Fear} and begins to walk slowly toward you.");
            Console.WriteLine("You've faced this before but it looks more monstorus, disgusting and more terrifying than the swarm. You feel horror but ou realize if you faced it beofre you can do it again...");
            Console.WriteLine(" You decide to trust yourself and fight your fears and even overcame them for a second but now you must take on greater and more challenging creature...will ou be ready?");
            
            Console.WriteLine("End of level one.");
            Console.ReadKey();
            System.Environment.Exit(0);



        }

        //If player leaves the ghost woman and encouters the ogre on their own, leads to demon ending of being alone.
        static void Leavewoman()

        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" You exit the Hallway to see the previous path is no longer there yet you see a new door that wasn't there before...");
            Console.WriteLine("you go through.....");
            Console.WriteLine($"Suddenly the door slams and you are trapped and you feel trapped! You begin to be swarmed by {CurrentPlayer.Fear}!  ");
            Console.WriteLine(" What are you going to do?");
            Console.ResetColor();

            string input = "";
            Console.WriteLine("Press 1 to Run away to find cover!) or Press 2 to Stay in the swarm!)");
            input = Console.ReadLine();
            if (input == "1")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" You Decided to run...");
                Console.WriteLine($" You run and find a nerby door. You slam the door and hide and wait for the swarm of {CurrentPlayer.Fear} to pass by.  ");
                Console.WriteLine(" You hear nothing....");
                Console.WriteLine($"Suddenly the door is pushed open wide and you are engulfed in {CurrentPlayer.Fear}, no where to run, no where to hide just empty....");
                Console.WriteLine(" You have perished....");


                Console.WriteLine(@"_                   _
                                     _( )                 ( )_
                                    (_, |      __ __      | ,_)
                                       \'\    /  ^  \    /'/
                                        '\'\,/\      \,/'/'
                                          '\| []   [] |/'
                                            (_  /^\  _)
                                              \  ~  /
                                              /HHHHH\
                                            /'/{^^^}\'\
                                        _,/'/'  ^^^  '\'\,_
                                       (_, |           | ,_)
                                         (_)           (_)");
                Console.ResetColor();

                CheckpointA();




            }
            else if
            (input == "2")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You chose to face your Fear");
                Console.ResetColor();

                Console.WriteLine($"As you are stand in the {CurrentPlayer.Fear} You dont feel any pain yet you still feel uneasy.");
                Console.WriteLine(" The swarm disapears but something menacing takes its place. Something Big.");
                Console.Clear();

                Ogre Thor = new Ogre("Thor", "Bloodreach");
                Thor.Meet2();


                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" The ogre grabs me and walks me to a door and throws me in.");
                Console.WriteLine(" The room is dark but I hear a low growl in front of me. There is a beast..it looks at me with hunger in its eyes...");
                Console.WriteLine(" Im its dinner...");
                EndA(); 


            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("you must choose...");
                Console.ResetColor();

                Leavewoman();


            }

        }

       




    }
}
