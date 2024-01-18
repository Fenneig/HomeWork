using Lesson_1.Scripts.WeaponTask.FirePattern;
using Lesson_1.Scripts.WeaponTask.Magazine;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Lesson_1.Scripts.WeaponTask
{
    public class InputListener : MonoBehaviour
    {
        [SerializeField] private Gun _gun;
        [SerializeField] private Material _weapon1;
        [SerializeField] private Material _weapon2;
        [SerializeField] private Material _weapon3;

        private LessonInput _lessonInput;

        private void Awake()
        {
            _lessonInput = new LessonInput();
        }

        private void OnEnable()
        {
            _lessonInput.Weapon.Enable();
        }

        private void OnDisable()
        {
            _lessonInput.Weapon.Disable();
        }

        private void Start()
        {
            SubscribeOnWeaponMethods();
            
            FiniteMagazine finiteMagazine = new FiniteMagazine(8);
            _gun.Initialize(finiteMagazine, 1, new SingleFirePattern(), _weapon1);
        }

        private void SubscribeOnWeaponMethods()
        {
            _lessonInput.Weapon.Fire.started += OnFire;
            _lessonInput.Weapon.Switch_weapon_1.started += OnSwitch_weapon_1;
            _lessonInput.Weapon.Switch_weapon_2.started += OnSwitch_weapon_2;
            _lessonInput.Weapon.Switch_weapon_3.started += OnSwitch_weapon_3;
            _lessonInput.Weapon.Reload.started += OnReload;
        }

        private void OnFire(InputAction.CallbackContext context)
        {
            _gun.Fire();
        }

        private void OnSwitch_weapon_1(InputAction.CallbackContext context)
        {
            FiniteMagazine finiteMagazine = new FiniteMagazine(8);
            _gun.Initialize(finiteMagazine, 1, new SingleFirePattern(), _weapon1);
        }

        private void OnSwitch_weapon_2(InputAction.CallbackContext context)
        {
            InfiniteMagazine infiniteMagazine = new InfiniteMagazine();
            _gun.Initialize(infiniteMagazine, 1, new SingleFirePattern(), _weapon2);
        }

        private void OnSwitch_weapon_3(InputAction.CallbackContext context)
        {
            FiniteMagazine finiteMagazine = new FiniteMagazine(30);
            _gun.Initialize(finiteMagazine, 3, new MultiShotFirePattern(3), _weapon3);
        }

        private void OnReload(InputAction.CallbackContext context)
        {
            _gun.Reload();
        }
    }
}
