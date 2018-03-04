using ChessDotNet; // the namespace of Chess.NET
using System;
using System.Collections.Generic;
using System.Linq;

namespace Samples
{
    class mymain
    {
        static void Main(string[] args)
        {
            string from, to;
            
            // Let's start by creating a chess game instance.
            ChessGame game = new ChessGame();
            while (!game.Terminated)
            {
                char c;
                bool valid = false;
                Move fromto = null;
                // Now the game's board is in the start position and it's white's turn.
                Console.WriteLine("It's {0}", game.WhoseTurn);
                Console.WriteLine("please enter your move");
                while (!valid)
                {
                    from = Console.ReadLine();
                    to = Console.ReadLine();
                    if ((from == "a7" && to == "a8" && game.GetPieceAt(new Position("a7")).GetFenCharacter() == 'P')
                        || (from == "b7" && to == "b8" && game.GetPieceAt(new Position("b7")).GetFenCharacter() == 'P')
                        || (from == "c7" && to == "c8" && game.GetPieceAt(new Position("c7")).GetFenCharacter() == 'P')
                        || (from == "d7" && to == "d8" && game.GetPieceAt(new Position("d7")).GetFenCharacter() == 'P')
                        || (from == "e7" && to == "e8" && game.GetPieceAt(new Position("e7")).GetFenCharacter() == 'P')
                        || (from == "f7" && to == "f8" && game.GetPieceAt(new Position("f7")).GetFenCharacter() == 'P')
                        || (from == "g7" && to == "g8" && game.GetPieceAt(new Position("g7")).GetFenCharacter() == 'P')
                        || (from == "h7" && to == "h8" && game.GetPieceAt(new Position("h7")).GetFenCharacter() == 'P')
                        || (from == "a2" && to == "a1" && game.GetPieceAt(new Position("a2")).GetFenCharacter() == 'p')
                        || (from == "b2" && to == "b1" && game.GetPieceAt(new Position("b2")).GetFenCharacter() == 'p')
                        || (from == "c2" && to == "c1" && game.GetPieceAt(new Position("c2")).GetFenCharacter() == 'p')
                        || (from == "d2" && to == "d1" && game.GetPieceAt(new Position("d2")).GetFenCharacter() == 'p')
                        || (from == "e2" && to == "e1" && game.GetPieceAt(new Position("e2")).GetFenCharacter() == 'p')
                        || (from == "f2" && to == "f1" && game.GetPieceAt(new Position("f2")).GetFenCharacter() == 'p')
                        || (from == "g2" && to == "g1" && game.GetPieceAt(new Position("g2")).GetFenCharacter() == 'p')
                        || (from == "h2" && to == "h1" && game.GetPieceAt(new Position("h2")).GetFenCharacter() == 'p'))


                    {
                        c = (char)Console.Read();
                        fromto = new Move(from, to, game.WhoseTurn, c);
                        valid = game.IsValidMove(fromto);
                    }
                    else
                    {
                        fromto = new Move(from, to, game.WhoseTurn);
                        valid = game.IsValidMove(fromto);
                    }


                }
                //3ayz a2ol while law da5l almove fe formatha sa7 3shan maydesh exception
                //3ayz azawd alpromotion

                MoveType mtype;
                
                mtype = game.ApplyMove(fromto, true);
            }
            if (game.DrawClaimed)
                Console.WriteLine("draw claimed");
            else if (game.IsCheckmated(Player.Black))
                Console.WriteLine("white wins");
            else if (game.IsCheckmated(Player.White))
                Console.WriteLine("black wins");

            Console.ReadKey();
        }
    }
}
