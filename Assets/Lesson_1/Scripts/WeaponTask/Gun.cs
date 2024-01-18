using Lesson_1.Scripts.WeaponTask.Magazine;
using TMPro;
using UnityEngine;

namespace Lesson_1.Scripts.WeaponTask
{
    public class Gun : MonoBehaviour
    {
        [SerializeField] private Transform _barrelEnd;
        [SerializeField] private Bullet _bulletPrefab;
        [SerializeField] private TMP_Text _magazineText;
        [SerializeField] private MeshRenderer _mesh;

        private GunMagazine _gunMagazine;
        private IFirePattern _firePattern;
        private int _ammoPerShoot;

        public void Initialize(GunMagazine gunMagazine, int ammoPerShoot, IFirePattern firePattern, Material weaponMaterial)
        {
            _gunMagazine = gunMagazine;
            gunMagazine.OnAmmoChanged = UpdateMagazineInfo;
            UpdateMagazineInfo();
            _ammoPerShoot = ammoPerShoot;
            _firePattern = firePattern;
            _mesh.material = weaponMaterial;
        }

        public void Fire()
        {
            if (_gunMagazine.TrySpendAmmo(_ammoPerShoot)) Shoot();
        }

        public void Reload() => _gunMagazine.Reload();

        private void UpdateMagazineInfo() => _magazineText.text = _gunMagazine.ShowAmmo();

        private void Shoot() =>
            _firePattern?.Shoot(_bulletPrefab, _barrelEnd.position);
    }
}