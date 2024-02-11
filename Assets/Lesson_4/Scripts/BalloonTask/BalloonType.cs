using UnityEngine;

namespace Lesson_4.Scripts.BalloonTask
{
    [CreateAssetMenu(menuName = "Lesson_4/BalloonType", fileName = "BalloonType")]
    public class BalloonType : ScriptableObject
    {
        [SerializeField] private BalloonColor _balloonColor;
        [SerializeField] private Material _representColor;

        public BalloonColor BalloonColor => _balloonColor;
        public Material RepresentColor => _representColor;
    }
}