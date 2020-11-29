using TestTaskMpulseProjectMaterials.Scripts.Essences;
using UnityEngine;

namespace TestTaskMpulseProjectMaterials.Scripts.WebViewScene
{
    public class WebViewSceneManager 
        : MonoBehaviour
    {
        private void OnApplicationPause(bool pauseStatus) 
        {
            if (pauseStatus)
            {
                UniWebView.GetCookie(PlayerPrefs.GetString(KeyDataDTO.DeepLinkKey), 
                    KeyDataDTO.LastSessionKey);
            }
        }
    }
}