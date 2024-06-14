namespace BallGame.Player.Controller
{
    public class MoveState : BaseState
    {
        public MoveState(PlayerController player):base(player) { }

        public override void Enter() 
        { 
            base.Enter();
        }
        public override void Tick()
        { 
            base.Tick();

            _player.MoveComp.GetMoveInput(_player.MoveInput);
            if (_player.HitTime > 0)
            {
                _player.MoveComp.GetMoveInput(0);
                _player.ChangeState(_player.hitBallState);
            }
        }
        public override void Exit() 
        { 
            base.Exit();
        }
    }
}