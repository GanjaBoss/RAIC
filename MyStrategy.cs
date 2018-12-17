using Com.CodeGame.CodeBall2018.DevKit.CSharpCgdk.Model;

namespace Com.CodeGame.CodeBall2018.DevKit.CSharpCgdk
{
    public sealed class MyStrategy : IStrategy
    {
        public void Act(Robot me, Rules rules, Game game, Action action)
        {
            Math.Vector ball = Converter.BallToVector(game.ball);
            //инициализируем анализатор игрового состояния
            GameState gamestate = new GameState(me,  rules,  game, action);
            me.
        }

        class Actions
        {
            public void JumpOver(Math.Vector)
            {
                
            }
        }
    }
}
