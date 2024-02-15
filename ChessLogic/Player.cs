
namespace ChessLogic
{
    public enum Player // Will be used to store which player's turn it is and who won the game, as well as, represent the color of the chess pieces
    {
        None,
        White,
        Black
    }

    public static class PlayerExtensions
    {
        public static Player Opponent(this Player player) // Will take a player as parameter and return that player's opponent
        {
            return player switch
            {
                Player.White => Player.Black,
                Player.Black => Player.White,
                _ => Player.None,
            };
        }
    }
}
