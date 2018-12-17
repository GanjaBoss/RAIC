using System;
using System.Collections.Generic;
using System.Text;
using Com.CodeGame.CodeBall2018.DevKit.CSharpCgdk.Model;


namespace Com.CodeGame.CodeBall2018.DevKit.CSharpCgdk
{
    public class GameState
    {
        Robot _robot;
        Rules _rules;
        Game _game;
        Model.Action _action;

        public GameState(Robot me, Rules rules, Game game, Model.Action action)
        {
            _robot = me;
            _rules = rules;
            _game = game;
            _action = action;
        }

        public void 
    }
}
