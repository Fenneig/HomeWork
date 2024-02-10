using Lesson_4.Scripts.NPC.UI;
using Lesson_4.Scripts.NPC.Units;

namespace Lesson_4.Scripts.NPC
{
    public class UIMediator
    {
        private readonly NpcUi _ui;
        
        public UIMediator(NpcUi ui)
        {
            _ui = ui;
        }

        public void RegisterCharacter(Character character)
        {
            var status = character.Status;
            status.EnergyUpdated += OnEnergyUpdated;
            status.InventoryUpdated += OnInventoryUpdated;

            _ui.UpdateValues(status.CurrentEnergy, status.MaxEnergy, status.CurrentInventoryCapacity, status.MaxInventoryCapacity);
            _ui.Show();
        }

        public void UnregisterCharacter(Character character)
        {
            _ui.Hide();
            
            character.Status.EnergyUpdated -= OnEnergyUpdated;
            character.Status.InventoryUpdated -= OnInventoryUpdated;
        }

        private void OnEnergyUpdated(int currentAmount) => _ui.UpdateEnergy(currentAmount);
        private void OnInventoryUpdated(int currentAmount) => _ui.UpdateInventory(currentAmount);
    }
}