using UnityEngine;

namespace TestTaskMpulseProjectMaterials.Scripts.WebViewScene
{
    public class SettingsWebViewScene 
        : MonoBehaviour
    {
        private void Awake()
        {
            Screen.orientation = ScreenOrientation.AutoRotation; 
        }
    }
}