using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCase3CheckForOption
{
    internal class UC3CheckOption
    {
        static int START_POSITION = 0;

        static int WINNING_POSITION = 100;
        public static void winningPosition()
        {
            Console.WriteLine("Welcome to snake ladder game");
            Console.WriteLine("Player will start from zero position");

                Random random1 = new Random();
                int checkOptions = random1.Next(0, 3);
                switch (checkOptions)
                {

                    case 0:
                        {
                            Console.WriteLine("There will be no play. Player will be at same position");
                        }
                        break;

                    case 1:
                    
                            Console.WriteLine("Player will move forward");
                          
                        break;
                    case 2:
                       
                            Console.WriteLine("Player is bitten by a snake");

                        break;
                    default:
                    Console.WriteLine("start game again");
                    break ;

                }

        
            }
        }
    }

