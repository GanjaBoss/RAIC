using Com.CodeGame.CodeBall2018.DevKit.CSharpCgdk.Model;

namespace Com.CodeGame.CodeBall2018.DevKit.CSharpCgdk
{
    public sealed class MyStrategy : IStrategy
    {
        public void Act(Robot me, Rules rules, Game game, Action action)
        {
            //инициализируем анализатор игрового состояния
            GameState gamestate = new GameState(me,  rules,  game, action);



            var act = new Action().CreateAction(game.ball.GetVector());
            var act2 = new Action().CreateAction(new Math.Coordinate(game.ball.x, game.ball.y, game.ball.z));
            var act3 = new Action();
            act3.target_velocity_x = game.ball.x;
            act3.target_velocity_y = game.ball.y;
            act3.target_velocity_y = game.ball.y;

            action.target_velocity_x = game.ball.x;
            action.target_velocity_y = game.ball.y;
            action.target_velocity_y = game.ball.y;




            //action.CreateAction(game.ball.GetVector());

            return;

        }

        class Actions
        {
            //public void JumpOver(Math.Vector)
            //{
                
            //}
        }
    }
}
