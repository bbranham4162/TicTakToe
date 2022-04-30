

using System;

    namespace TicTakToe{

    
    class program{

        static void Main(string[] args){
            int turn = 0;
            bool hello = false;
            String[] board = initializeBoard();
            displayBoard(board);
            
            while(hello != true){

                int choice = userinput(turn);

                String[] player = updateBoard(turn, board, choice);
                displayBoard(player);

                hello = checkWinner(player);

            turn += 1;
                if (turn == 9){
                    Console.WriteLine("ITS A DRAW!!!");
                    hello = true;
                }
            }

        }
        static String[] initializeBoard(){

            String[] board = {"1", "2", "3", "4", "5","6", "7", "8", "9"};

            return board;
    
        
        }

        static void displayBoard(String[] board){

            Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}|");
            Console.WriteLine($"{board[3]}|{board[4]}|{board[5]}|");
            Console.WriteLine($"{board[6]}|{board[7]}|{board[8]}|");
            
           
                
            }
            
        static int userinput(int turn){
            if (turn % 2 == 0){
            Console.Write($" X's turn to pick a square (1-9)");
            int choice = Int32.Parse(Console.ReadLine());
            return choice;}

            else{
            Console.Write($" O's turn to pick a square (1-9)");
            int choice = Int32.Parse(Console.ReadLine());
            return choice;}
        }

        static String[] updateBoard(int turn, String[] board, int choice){

            if (turn % 2 == 0)
            {
               board[choice - 1] = "x";
               return board;
        }
            else{
                board[choice - 1] = "o";
                return board;
            }
        }

        static Boolean checkWinner(String[] board){

            if (board[0] == "x" && board[1] == "x" && board[2] == "x" ||
            board[3] == "x" && board[4] == "x" && board[5] =="x" ||
            board[6] == "x" && board[7] == "x" && board[8] == "x"||
            board[0] == "x" && board[3] == "x" && board[6] == "x" ||
            board[1] == "x" && board[4] == "x" && board[7] == "x" ||
            board[2] == "x" && board[5] == "x" && board[8] == "x" ||
            board[0] == "x" && board[4] == "x" && board[8] == "x" ||
            board[2] == "x" && board[4] == "x" && board[6] == "x"){
                Console.WriteLine("Congrats X's WIN!!!!!");
                return true;}
            else if (board[0] == "o" && board[1] == "o" && board[2] == "o" ||
            board[3] == "o" && board[4] == "o" && board[5] == "o" ||
            board[6] == "o" && board[7] == "o" && board[8] == "o" ||
            board[0] == "o" && board[3] == "o" && board[6] == "o" ||
            board[1] == "o" && board[4] == "o" && board[7] == "o" ||
            board[2] == "o" && board[5] == "o" && board[8] == "o" ||
            board[0] == "o" && board[4] == "o" && board[8] == "o" ||
            board[2] == "o" && board[4] == "o" && board[6] == "o" ){
                Console.WriteLine("Congrats O's WIN!!!!!");
                return true;}

            return false;
            }
            
            

            

                
                
            }
        }
    

       
    
    

//main(...)
//{}
        //Create variables

        //while(stillPlaying){
        //GetPlayers input
        // update the game
        // check win or draw conditions
        // render the output
        //switch to next player
        //update still playing 


//static when defining functions
        


//data

// Player1: string(x)(o)
// Player2: string(x)(o)

// currentplayer: string(x)(o)
// grid: string[]
//stillplaying: boolean

//Operations::

//(named as Verbfollowedbynoun)

//Checkforwin(grid)boolean
//checkfordraw(grid)boolean
//createGrid(grid)grid

//makeMark(currentPlayer, grid, cell) void

//getCell(currentPlayer)

//drawGrid
