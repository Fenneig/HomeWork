using UnityEngine;

namespace Lesson_1.Scripts.WeaponTask.FirePattern
{
    public class SingleFirePattern : IFirePattern
    {
        public void Shoot(Bullet bulletPrefab, Vector3 initPosition)
        {
            Bullet bullet = Bullet.Instantiate(bulletPrefab, initPosition, Quaternion.identity);
            bullet.Fire();
        }
    }
}