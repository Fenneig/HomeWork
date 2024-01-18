using UnityEngine;

namespace Lesson_1.Scripts.WeaponTask
{
    public class MultiShotFirePattern : IFirePattern
    {
        private readonly int _shotsAmount;
        
        public MultiShotFirePattern(int shotsAmount) => _shotsAmount = shotsAmount;
        public void Shoot(Bullet bulletPrefab, Vector3 initPosition)
        {
            for (int i = 0; i < _shotsAmount; i++)
            {
                Bullet bullet = Bullet.Instantiate(bulletPrefab, initPosition, Quaternion.identity);
                bullet.Fire();
            }
        }
    }
}