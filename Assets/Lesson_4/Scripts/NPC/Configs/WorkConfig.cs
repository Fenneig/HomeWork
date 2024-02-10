using UnityEngine;

namespace Lesson_4.Scripts.NPC.Configs
{
    [CreateAssetMenu(menuName = "NPC/Lesson_4/Work config", fileName = "Work config")]
    public class WorkConfig : ScriptableObject
    {
        [field: SerializeField] public int WorkEnergyCost { get; private set; }
        [field: SerializeField] public int AddInInventoryAmount { get; private set; }
    }
}