using Lesson_3.Scripts.FactoryExample.Images;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Lesson_3.Scripts.FactoryExample
{
    public class InterfaceDrawer : MonoBehaviour
    {
        [SerializeField] private Image _energyImage;
        [ImageId] [SerializeField] private string _energyId;
        [SerializeField] private Image _moneyImage;
        [ImageId] [SerializeField] private string _moneyId; 
        [SerializeField] private InterfaceType _interfaceType;

        private ImagesFactory _imagesFactory;

        [Inject]
        public void Construct(ImagesFactory imagesFactory) => _imagesFactory = imagesFactory;

        private void Awake()
        {
            _energyImage.sprite = _imagesFactory.Get(_energyId, _interfaceType);
            _moneyImage.sprite = _imagesFactory.Get(_moneyId, _interfaceType);
        }
    }
}