using Lesson_4.Scripts.NPC.Configs;
using UnityEngine;
using Zenject;

namespace Lesson_4.Scripts.NPC.DI
{
    public class ConfigInstallers : MonoInstaller
    {
        [SerializeField] private CharacterConfig _characterConfig;

        public override void InstallBindings()
        {
            Container.Bind<CharacterConfig>().FromInstance(_characterConfig).AsSingle();
        }
    }
}