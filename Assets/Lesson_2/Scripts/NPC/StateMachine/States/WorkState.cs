using Lesson_2.Scripts.NPC.StateMachine.States.WalkStates;
using Lesson_2.Scripts.NPC.Units;

namespace Lesson_2.Scripts.NPC.StateMachine.States
{
    public class WorkState : State
    {
        private bool _isWorkFinished;
        
        public WorkState(IStateSwitcher stateSwitcher, Character character) : base(stateSwitcher, character)
        { }

        public override void Enter()
        {
            base.Enter();

            _isWorkFinished = false;
            CharacterView.StartWorking();
            CharacterView.CheckStatus += OnCheckStatus;
        }

        public override void Exit()
        {
            base.Exit();
            
            CharacterView.StopWorking();
            CharacterView.CheckStatus -= OnCheckStatus;
        }

        public override void Update()
        {
            base.Update();
            
            if (_isWorkFinished)
                StateSwitcher.SwitchState<WalkDeliverState>();
        }

        private void OnCheckStatus()
        {
            _isWorkFinished = CharacterStatus.IsInventoryFull || CharacterStatus.IsEnergyEmpty;
        }
    }
}