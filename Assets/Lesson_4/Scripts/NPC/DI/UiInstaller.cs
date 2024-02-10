using Lesson_4.Scripts.NPC.UI;
using UnityEngine;
using Zenject;

namespace Lesson_4.Scripts.NPC.DI
{
    public class UiInstaller : MonoInstaller
    {
        [SerializeField] private NpcUi _ui;

        public override void InstallBindings()
        {
            Container.Bind<NpcUi>().FromInstance(_ui).AsSingle();
        }
    }
}