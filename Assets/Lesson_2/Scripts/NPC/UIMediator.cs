using Lesson_2.Scripts.NPC.UI;

namespace Lesson_2.Scripts.NPC
{
    public class UIMediator
    {
        private readonly NpcUi _ui;
        public UIMediator(NpcUi ui, Units.Character character)
        {
            _ui = ui;

            character.Status.EnergyUpdated += OnEnergyUpdated;
            character.Status.InventoryUpdated += OnInventoryUpdated;
        }

        private void OnEnergyUpdated(int currentAmount) => _ui.UpdateEnergy(currentAmount);
        private void OnInventoryUpdated(int currentAmount) => _ui.UpdateInventory(currentAmount);
    }
}