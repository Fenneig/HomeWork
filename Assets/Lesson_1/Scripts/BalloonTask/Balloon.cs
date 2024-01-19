using System;
using UnityEngine;

namespace Lesson_1.Scripts.BalloonTask
{
    public class Balloon : MonoBehaviour
    {
        [SerializeField] private MeshRenderer _balloonMesh;
        [SerializeField] private BalloonType _balloonType;

        public event Action<BalloonColor> OnBalloonBursted;
        public BalloonColor Color => _balloonType.BalloonColor;

        private void Awake() => _balloonMesh.material = _balloonType.RepresentColor;

        public void Burst()
        {
            OnBalloonBursted?.Invoke(_balloonType.BalloonColor);
            gameObject.SetActive(false);
            OnBalloonBursted = null;
        }
    }
}