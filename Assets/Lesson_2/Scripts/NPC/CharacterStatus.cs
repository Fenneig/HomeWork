using System;
using UnityEngine;

namespace Lesson_2.Scripts.NPC
{
    [Serializable]
    public class CharacterStatus
    {
        private CharacterConfig _characterConfig;
        [SerializeField] private int _currentEnergy;
        [SerializeField] private int _currentInventoryCapacity;

        public bool IsEnergyEmpty { get; private set; }
        public bool IsInventoryFull { get; private set; }

        public CharacterStatus(CharacterConfig characterConfig)
        {
            _characterConfig = characterConfig;
            _currentEnergy = characterConfig.MaxEnergy;
            _currentInventoryCapacity = 0;
        }

        public void SpendEnergy(int amount)
        {
            _currentEnergy -= amount;

            if (_currentEnergy > 0) return;
            
            _currentEnergy = 0;
            IsEnergyEmpty = true;
        }

        public void RestoreEnergy()
        {
            _currentEnergy = _characterConfig.MaxEnergy;
            IsEnergyEmpty = false;
        }

        public bool TryAddInInventory(int amount)
        {
            if (_currentInventoryCapacity + amount > _characterConfig.MaxInventoryCapacity)
            {
                IsInventoryFull = true;
                return false;
            }
            
            _currentInventoryCapacity += amount;
            
            if (_currentInventoryCapacity == _characterConfig.MaxInventoryCapacity) 
                IsInventoryFull = true;
            
            return true;
        }

        public void FreeInventory()
        {
            _currentInventoryCapacity = 0;
            IsInventoryFull = false;
        }
    }
}