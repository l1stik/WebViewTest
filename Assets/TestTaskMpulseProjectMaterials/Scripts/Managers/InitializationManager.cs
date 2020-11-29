using TestTaskMpulseProjectMaterials.Scripts.InitializingServicesScene;
using UnityEngine;

namespace TestTaskMpulseProjectMaterials.Scripts.Managers
{
    public class InitializationManager : MonoBehaviour
    {
        [SerializeField]
        private OutputData _outputDataScene;
        
        private void Awake()
        {
            FbManager.InitializedFbSdk();
            AppsFlyerManager.InitializedAppsFlyerSdk();
            
            _outputDataScene.ShowDataOutput();
        }
    }
}