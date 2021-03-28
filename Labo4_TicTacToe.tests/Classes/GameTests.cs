using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Lab04_TicTacToe.Classes;

namespace Labo4_TicTacToe.tests.Classes
{
    public class GameTests
    {
        [Fact]
        public void Game_given_board_test_for_winners()
        {
            // arrange
            Board board = new Board();

            // act & assert
            Assert.False(Game.CheckForWinner(board));
            board.GameBoard[0, 0] = "O";
            board.GameBoard[1, 1] = "O";
            board.GameBoard[2, 2] = "O";
            Assert.True(Game.CheckForWinner(board));

        }
        [Fact]
        public void Game_switch_player_changes_player_isturn_field()
        {
            // arrange
        }
        [Fact]
        public void Confirm_player_position_refers_to_correct_space_on_board()
        {
            // arrange
            // act
            // assert
        }
        [Fact]
        public void Game_NextPlayer_returns_active_player()
        {
            // arrange
            // act
            // assert
        }
    }
}
