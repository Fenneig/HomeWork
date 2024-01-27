using Lesson_2.Scripts.NPC.StateMachine.States.WalkStates;

namespace Lesson_2.Scripts.NPC.StateMachine.States
{
    public class RestState : State
    {
        private bool _isReadyForWork;
        
        public RestState(IStateSwitcher stateSwitcher, Units.Character character) : base(stateSwitcher, character)
        { }

        public override void Enter()
        {
            base.Enter();

            _isReadyForWork = false;
            CharacterView.StartRest();
            CharacterView.CheckStatus += OnCheckStatus;
        }

        private void OnCheckStatus()
        {
            _isReadyForWork = CharacterStatus.IsEnergyEmpty == false;
        }

        public override void Exit()
        {
            base.Exit();
            
            CharacterView.StopRest();
            CharacterView.CheckStatus -= OnCheckStatus;
        }

        public override void Update()
        {
            base.Update();
            
            if (_isReadyForWork) 
                StateSwitcher.SwitchState<WalkWorkState>();
        }
    }
}