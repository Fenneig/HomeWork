using Lesson_4.Scripts.NPC.StateMachine.States.WalkStates;
using Lesson_4.Scripts.NPC.Units;
using Lesson_4.Scripts.NPC.StateMachine.States.WalkStates;

namespace Lesson_4.Scripts.NPC.StateMachine.States
{
    public class DeliverState : State
    {
        public DeliverState(IStateSwitcher stateSwitcher, Character character) : base(stateSwitcher, character)
        { }

        public override void Enter()
        {
            base.Enter();
            
            CharacterView.StartDelivering();
            CharacterView.CheckStatus += OnCheckStatus;
        }

        public override void Exit()
        {
            base.Exit();
            
            CharacterView.StopDelivering();
            CharacterView.CheckStatus -= OnCheckStatus;
        }

        private void OnCheckStatus()
        {
            if (CharacterStatus.IsEnergyEmpty)
            {
                StateSwitcher.SwitchState<WalkRestState>();
                return;
            }

            if (CharacterStatus.IsInventoryFull == false)
            {
                StateSwitcher.SwitchState<WalkWorkState>();
                return;
            }
        }
    }
}