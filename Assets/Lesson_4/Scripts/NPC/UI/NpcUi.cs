using UnityEngine;
using UnityEngine.UI;

namespace Lesson_4.Scripts.NPC.UI
{
    public class NpcUi : MonoBehaviour
    {
        [SerializeField] private GameObject _uiPanel;
        [SerializeField] private Image _energyImage;
        [SerializeField] private Image _inventoryImage;

        private int _maxEnergy;
        private int _maxInventoryCapacity;

        public void UpdateValues(int currentEnergy, int maxEnergy, int currentInventoryCapacity, int maxInventoryCapacity)
        {
            _maxEnergy = maxEnergy;
            _maxInventoryCapacity = maxInventoryCapacity;
            
            UpdateEnergy(currentEnergy);
            UpdateInventory(currentInventoryCapacity);
        }

        public void Show() => _uiPanel.SetActive(true);
        public void Hide() => _uiPanel.SetActive(false);

        public void UpdateEnergy(int currentEnergy) => _energyImage.fillAmount = (float) currentEnergy /_maxEnergy;
        public void UpdateInventory(int currentInventoryCapacity) => _inventoryImage.fillAmount = (float) currentInventoryCapacity /_maxInventoryCapacity;
    }
}