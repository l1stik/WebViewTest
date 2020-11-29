using UnityEngine;

namespace TestTaskMpulseProjectMaterials.Scripts.InitializingServicesScene
{
    public class SettingsInitializingServicesScene
        : MonoBehaviour
    {
        private void Awake()
        {
            Screen.orientation = ScreenOrientation.Portrait;
        }
    }
}