using UnityEngine;

namespace Lesson_3.Scripts.Visitor
{
    public static class DebugHolder
    {
        public static void DebugWeight(int value) => Debug.Log($"Вес: {value}");
        public static void DebugScore(int value) => Debug.Log($"Счет: {value}");
    }
}