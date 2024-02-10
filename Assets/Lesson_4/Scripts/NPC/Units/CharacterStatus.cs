using System;
using Lesson_4.Scripts.NPC.Configs;

namespace Lesson_4.Scripts.NPC.Units
{
    public class CharacterStatus
    {
        private readonly int _maxEnergy;
        private readonly int _maxInventoryCapacity;
        
        private int _currentEnergy;
        private int _currentInventoryCapacity;

        public int CurrentEnergy => _currentEnergy;
        public int CurrentInventoryCapacity => _currentInventoryCapacity;
        public int MaxEnergy => _maxEnergy;
        public int MaxInventoryCapacity => _maxInventoryCapacity;
        public bool IsEnergyEmpty { get; private set; }
        public bool IsInventoryFull { get; private set; }

        public event Action<int> EnergyUpdated;
        public event Action<int> InventoryUpdated;

        public CharacterStatus(CharacterConfig characterConfig)
        {
            _maxEnergy = characterConfig.MaxEnergy;
            _maxInventoryCapacity = characterConfig.MaxInventoryCapacity;
            _currentEnergy = _maxEnergy;
            _currentInventoryCapacity = 0;
        }

        public void SpendEnergy(int amount)
        {
            _currentEnergy -= amount;
            EnergyUpdated?.Invoke(_currentEnergy);

            if (_currentEnergy > 0) return;
            
            _currentEnergy = 0;
            IsEnergyEmpty = true;
        }

        public void RestoreEnergy()
        {
            _currentEnergy = _maxEnergy;
            EnergyUpdated?.Invoke(_currentEnergy);
            IsEnergyEmpty = false;
        }

        public bool TryAddInInventory(int amount)
        {
            if (_currentInventoryCapacity + amount > _maxInventoryCapacity)
            {
                IsInventoryFull = true;
                return false;
            }
            
            _currentInventoryCapacity += amount;
            InventoryUpdated?.Invoke(_currentInventoryCapacity);
            
            if (_currentInventoryCapacity == _maxInventoryCapacity) 
                IsInventoryFull = true;
            
            return true;
        }

        public void FreeInventory()
        {
            _currentInventoryCapacity = 0;
            InventoryUpdated?.Invoke(_currentInventoryCapacity);
            IsInventoryFull = false;
        }
    }
}