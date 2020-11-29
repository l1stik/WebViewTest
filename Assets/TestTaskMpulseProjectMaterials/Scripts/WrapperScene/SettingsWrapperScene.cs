using UnityEngine;

namespace TestTaskMpulseProjectMaterials.Scripts.WrapperScene
{
    public class SettingsWrapperScene 
        : MonoBehaviour
    {
        private void Awake()
        {
            Screen.orientation = ScreenOrientation.Landscape;
            Screen.autorotateToLandscapeLeft = true;
            Screen.autorotateToLandscapeRight = true;
        }
    }
}