using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    public class Ogre
    {



        public string Name { get; set; }
        public string Type { get; set; }


        public Ogre(string name,string type )
        {

            Name = name;
            Type =  type;

        }



        //Ascii art by Zeus(https://ascii.co.uk/art/ogre)
        public void Meet()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" Human made it this far...... impressive.......Name is {Name}, of {Type} clan... You smell of a that fool demon......uhhhh give me word! You trap here unless you give me word.. ");

            Console.WriteLine(@" 
                           __,='`````'=/__
                          '//  (o) \(o) \ `'         _,-,
                          //|     ,_)   (`\      ,-'`_,-\
                        ,-~~~\  `'===' /-,      \==```` \__
                       /        `----'     `\     \       \/
                    ,-`                  ,   \  ,.-\       \
                   /      ,               \,-`\`_,-`\_,..--'\
                  ,`    ,/,              ,>,   )     \--`````\
                  (      `\`---'`  `-,-'`_,<   \      \_,.--'`
                   `.      `--. _,-'`_,-`  |    \
                    [`-.___   <`_,-'`------(    /
                    (`` _,-\   \ --`````````|--`
                     >-`_,-`\,-` ,          |
                   <`_,'     ,  /\          /
                    `  \/\,-/ `/  \/`\_/V\_/
                       (  ._. )    ( .__. )
                       |      |    |      |
                        \,---_|    |_---./
                        ooOO(_)    (_)OOoo");


        }


        public void Meet2()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" Human made it this far...... impressive.......Name is {Name}, of {Type} clan... You smell...funny...No demon smell...no password either....dont know who to feed you to....well I choose random! HAHAHAHAHA! ");


            Console.WriteLine(@" 
                           __,='`````'=/__
                          '//  (o) \(o) \ `'         _,-,
                          //|     ,_)   (`\      ,-'`_,-\
                        ,-~~~\  `'===' /-,      \==```` \__
                       /        `----'     `\     \       \/
                    ,-`                  ,   \  ,.-\       \
                   /      ,               \,-`\`_,-`\_,..--'\
                  ,`    ,/,              ,>,   )     \--`````\
                  (      `\`---'`  `-,-'`_,<   \      \_,.--'`
                   `.      `--. _,-'`_,-`  |    \
                    [`-.___   <`_,-'`------(    /
                    (`` _,-\   \ --`````````|--`
                     >-`_,-`\,-` ,          |
                   <`_,'     ,  /\          /
                    `  \/\,-/ `/  \/`\_/V\_/
                       (  ._. )    ( .__. )
                       |      |    |      |
                        \,---_|    |_---./
                        ooOO(_)    (_)OOoo");







        }



    }
}
