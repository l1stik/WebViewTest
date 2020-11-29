using TestTaskMpulseProjectMaterials.Scripts.Essences;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace TestTaskMpulseProjectMaterials.Scripts.Managers
{
    public class SwitchingScenesManager 
        : MonoBehaviour
    {
        public static void NextScene()
        { 
            var locationUser = PlayerPrefs.GetString(KeyDataDTO.LocationKey);

            if (locationUser == KeyDataDTO.RussiaKey)
            {
                FbManager.SendEvent("webview-started");
                AppsFlyerManager.SendEvent("webview-started");

                LoadScene(KeyDataDTO.WebViewSceneName);
            }
            else
            {
                FbManager.SendEvent("wrapper-started");
                AppsFlyerManager.SendEvent("wrapper-started");
                    
                LoadScene(KeyDataDTO.WrapperSceneName);
            }
        }

        private static void LoadScene(string nameScene)
        {
            SceneManager.LoadScene(nameScene);
        }
    }
}