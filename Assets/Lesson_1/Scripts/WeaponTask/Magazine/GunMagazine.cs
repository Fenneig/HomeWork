using System;

namespace Lesson_1.Scripts.WeaponTask.Magazine
{
    public abstract class GunMagazine
    {
        public Action OnAmmoChanged;

        public abstract bool TrySpendAmmo(int amount);
        public abstract void Reload();
        public abstract string ShowAmmo();
    }
}