using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ESGI.DesignPattern.Projet
{
    class TennisGame1
    {
        private int player1_score;
        private int player2_score;
        private string player1_name;
        private string player2_name;

        public TennisGame1(string player1_name, string player2_name)
        {
            this.player1_name = player1_name;
            this.player2_name = player2_name;
            this.player1_score = 0;
            this.player2_score = 0;
        }

        public void WonPoint(string playerName)
        {
            if (playerName == player1_name)
                player1_score += 1;
            else if (playerName == player2_name)
                player2_score += 1;
        }

        public string GetScore()
        {
            if (player1_score == player2_score)
            {
                return Egalite(player1_score);
            }
            else if (player1_score >= 4 || player2_score >= 4)
            {
                return ScoreFinal(player1_score, player2_score);
            }
            else
            {
                return ScoreIntermediaire(player1_score) + "-" + ScoreIntermediaire(player2_score);
            }
        }

        private string ScoreIntermediaire(int player_score)
        {
            switch (player_score)
            {
                case 0:
                    return "Love";
                case 1:
                    return "Fifteen";
                case 2:
                    return "Thirty";
                case 3:
                    return "Forty";
                default:
                    return "";
            }
        }

        private string ScoreFinal(int player1_score, int player2_score)
        {
            string score;
            var ecartEntreLesJoueurs = player1_score - player2_score;
            switch (ecartEntreLesJoueurs)
            {
                case 1:
                    return "Advantage player1";
                case -1:
                    return "Advantage player2";
            }

            return ecartEntreLesJoueurs >= 2 ? "Win for player1" : "Win for player2";
        }

        private string Egalite(int player_score)
        {
            switch (player_score)
            {
                case 0:
                    return "Love-All";
                case 1:
                    return "Fifteen-All";
                case 2:
                    return "Thirty-All";
                default:
                    return "Deuce";
            }
        }
    }
}
