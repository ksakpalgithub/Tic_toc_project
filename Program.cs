using System;
using System.Threading;
namespace TIC_TAC_KVS
{
    class Program
    {
        //array to create matrix
        static char[] arr = { '0', '-', '2', '-', '4', '5', '6', '7', '8', '-' };
        static int player = 1; // set default player
        static int choice; //choice or array
        
        static int flag = 0;
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();// clear screen
                Console.WriteLine("Player1:X and Player2:O");
                Console.WriteLine("\n");
                Console.WriteLine("\n");
                Board();// creating board Function
                choice = int.Parse(Console.ReadLine());//Selection of choice
                
                if (arr[choice] != 'X' && arr[choice] != 'O')
                {

                    if (player % 2 == 0) //if chance is of player 2 then mark O else mark X
                    {
                        if (arr[choice] == '6')
                        {
                            arr[choice] = 'O';
                        }
                        else
                        {
                            if (arr[choice] == '7')
                            {
                                arr[choice] = 'O';
                            }
                            else
                            {
                                arr[choice] = 'X';
                            }

                        }

                        
                    }
                    else
                    {
                        arr[choice] = 'O';

                        player++;
                    }
                }
                else
                
                {
                    Console.WriteLine("The row {0} already marked with {1}", choice, arr[choice]);
                    Console.WriteLine("\n");
                    Console.WriteLine("Please wait 2 second .....");
                    Thread.Sleep(2000);
                }
                flag = CheckWin();// checking for win
            }
            while (flag != 1 && flag != -1);
            Console.Clear();// clear console
            Board();// calling board function
            if (flag == 1)
            
            {
                Console.WriteLine("Player {0} has won", (player % 2) + 1);
            }
            else 
            {
                Console.WriteLine("Draw");
            }
            Console.ReadLine();
        }
        // Board created
        private static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |      ");
        }
        //Checking that any player has won or not
        private static int CheckWin()
        {
            #region Horzontal Winning Condtion
            //Winning Condition For First Row
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }
            //Winning Condition For Second Row
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }
            //Winning Condition For Third Row
            else if (arr[6] == arr[7] && arr[7] == arr[8])
            {
                return 1;
            }
            #endregion
            #region vertical Winning Condtion
            //Winning Condition For First Column
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }
            //Winning Condition For Second Column
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }
            //Winning Condition For Third Column
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return 1;
            }
            #endregion
            #region Diagonal Winning Condition
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }
            #endregion
            #region Checking For Draw
            
            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return -1;
            }
            #endregion
            else
            {
                return 0;
            }
        }
    }
}