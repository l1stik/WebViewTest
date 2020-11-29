using TestTaskMpulseProjectMaterials.Scripts.Managers;
using UnityEngine;
using UnityEngine.UI;

namespace TestTaskMpulseProjectMaterials.Scripts.InitializingServicesScene
{
    public class SwitchButton 
        : MonoBehaviour
    {
        [SerializeField]
        private Button _switchButton;
        
        public void Start()
        {
            _switchButton.onClick.AddListener(SwitchingScenesManager.NextScene);
        }
    }
}