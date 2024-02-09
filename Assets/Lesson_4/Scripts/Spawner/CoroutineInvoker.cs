using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lesson_4.Scripts.Spawner
{
    public class CoroutineInvoker : MonoBehaviour
    {
        private Dictionary<string, IEnumerator> _routines = new();
        public void StartRoutine(string routineName, IEnumerator routine)
        {
            if (_routines.ContainsKey(routineName))
                return;

            _routines.Add(routineName, routine);
            StartCoroutine(routine);
        }

        public void ReleaseRoutine(string routineName)
        {
            if (_routines.ContainsKey(routineName) == false)
                return;

            StopCoroutine(_routines[routineName]);
            _routines.Remove(routineName);
        }
    }
}