using UnityEngine;

namespace Lesson_1.Scripts.BalloonTask
{
    [CreateAssetMenu(menuName = "Lesson_1/BalloonType", fileName = "BalloonType")]
    public class BalloonType : ScriptableObject
    {
        [SerializeField] private BalloonColor _balloonColor;
        [SerializeField] private Material _representColor;

        public BalloonColor BalloonColor => _balloonColor;
        public Material RepresentColor => _representColor;
    }
}