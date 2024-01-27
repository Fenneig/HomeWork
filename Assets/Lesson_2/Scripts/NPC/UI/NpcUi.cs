using UnityEngine;
using UnityEngine.UI;

namespace Lesson_2.Scripts.NPC.UI
{
    public class NpcUi : MonoBehaviour
    {
        [SerializeField] private Image _energyImage;
        [SerializeField] private Image _inventoryImage;

        private int _maxEnergy;
        private int _maxInventoryCapacity;

        public void Initialize(int currentEnergy, int maxEnergy, int currentInventoryCapacity, int maxInventoryCapacity)
        {
            _maxEnergy = maxEnergy;
            _maxInventoryCapacity = maxInventoryCapacity;
            
            UpdateEnergy(currentEnergy);
            UpdateInventory(currentInventoryCapacity);
        }

        public void UpdateEnergy(int currentEnergy) => _energyImage.fillAmount = (float) currentEnergy /_maxEnergy;
        public void UpdateInventory(int currentInventoryCapacity) => _inventoryImage.fillAmount = (float) currentInventoryCapacity /_maxInventoryCapacity;
    }
}