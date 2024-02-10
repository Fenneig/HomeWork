using UnityEngine;

namespace Lesson_4.Scripts.NPC.Configs
{
    [CreateAssetMenu(menuName = "NPC/Lesson_4/Character config", fileName = "Character config")]
    public class CharacterConfig : ScriptableObject
    {
        [field: SerializeField, Range(1, 10)] public float MoveSpeed { get; private set; }
        [field: SerializeField] public int MaxEnergy { get; private set; }
        [field: SerializeField] public int MaxInventoryCapacity { get; private set; }
        [field: SerializeField] public WorkConfig WorkConfig { get; private set; }
    }
}