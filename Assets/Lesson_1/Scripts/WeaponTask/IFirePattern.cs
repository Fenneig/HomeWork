using UnityEngine;

namespace Lesson_1.Scripts.WeaponTask
{
    public interface IFirePattern
    {
        public void Shoot(Bullet bulletPrefab, Vector3 initPosition);
    }
}