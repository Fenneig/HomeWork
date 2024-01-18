namespace Lesson_1.Scripts.WeaponTask.Magazine
{
    public class FiniteMagazine : GunMagazine
    {
        private int _currentAmmo;
        private int _maxAmmo;
        private bool _isInited;
        
        public FiniteMagazine(int maxAmmo)
        {
            if (_isInited) return;
            
            _isInited = true;
            _maxAmmo = maxAmmo;
            _currentAmmo = maxAmmo;
        }

        public override bool TrySpendAmmo(int amount)
        {
            if (_currentAmmo - amount < 0) return false;

            _currentAmmo -= amount;
            OnAmmoChanged?.Invoke();
            return true;
        }

        public override void Reload()
        {
            _currentAmmo = _maxAmmo;
            OnAmmoChanged?.Invoke();
        }

        public override string ShowAmmo() => $"{_currentAmmo}/{_maxAmmo}";
    }
}