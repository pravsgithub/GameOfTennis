﻿using System;
using System.Collections.Generic;

namespace GameOfTennisSimulation
{
    public class Set
    {
        private readonly Player _player1;
        private readonly Player _player2;

        private  int _player1GamesCount;
        private  int _player2GamesCount;

        private const int SetsToBePlayed = 3;

        public Set(Player player1, Player player2)
        {
            _player1 = player1;
            _player2 = player2;
        }
        public List<SetResult> Generate()
        {
            var setResults = new List<SetResult>();
            var random = new Random();

            for (int i = 1; i <= SetsToBePlayed; i++)
            {
                if (random.Next(2) == 1)
                {
                    setResults.Add(SimulateWinForPlayer1());
                }
                else
                {
                    setResults.Add(SimulateWinForPlayer2());
                }
            }

            return setResults;
        }

        public SetResult SimulateWinForPlayer1()
        {
            var setGeneratedResult = new SetResult();

            var random = new Random();
            while (_player1GamesCount != 6)
            {
                if (random.Next(2) == 1)
                {
                    GameWonBy(_player1);
                }
                else
                {
                    //if the player1 is winning with 6 games then the player 2 can only have score from 0-4 
                    //6-0, 6-1,6-2,6-3,6-4 <= possible scores
                    _player2GamesCount = random.Next(0, 4);
                }
            }


            setGeneratedResult.SetWinner = _player1GamesCount == 6 ? _player1 : _player2;
            setGeneratedResult.Score = $"{_player1GamesCount} - {_player2GamesCount}";
            return setGeneratedResult;
        }

        public SetResult SimulateWinForPlayer2()
        {
            var setGeneratedResult = new SetResult();

            var random = new Random();
            while (_player2GamesCount != 6)
            {
                if (random.Next(2) == 1)
                {
                    GameWonBy(_player2);
                }
                else
                {
                    _player1GamesCount = random.Next(0, 4);
                }
            }


            setGeneratedResult.SetWinner = _player1GamesCount == 6 ? _player1 : _player2;
            setGeneratedResult.Score = $"{_player1GamesCount} - {_player2GamesCount}";
            return setGeneratedResult;
        }

        private void GameWonBy(Player player)
        {
            if (player == _player1) { _player1GamesCount++; }

            if (player == _player2) { _player2GamesCount++; }
        }
    }
}