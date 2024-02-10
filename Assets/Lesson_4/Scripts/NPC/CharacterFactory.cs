using Lesson_4.Scripts.NPC.Units;
using UnityEngine;
using Zenject;

namespace Lesson_4.Scripts.NPC
{
    public class CharacterFactory
    {
        private DiContainer _diContainer;

        public CharacterFactory(DiContainer diContainer) => _diContainer = diContainer;
        
        public Character Get(Character prefab, Vector3 position) => 
            _diContainer.InstantiatePrefab(prefab, position, Quaternion.identity, null).GetComponent<Character>();
    }
}