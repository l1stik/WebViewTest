using Facebook.Unity;
using TestTaskMpulseProjectMaterials.Scripts.Essences;
using UnityEngine;

namespace TestTaskMpulseProjectMaterials.Scripts.Managers
{
    public static class FbManager
    { 
        public static void InitializedFbSdk ()
        {
            if (!FB.IsInitialized) 
            {
                FB.Init(InitCallback);
            } else {
                FB.ActivateApp();
            }
        }
    
        private static void DeepLinkCallback(IAppLinkResult result)
        {
            if (string.IsNullOrEmpty(result.Url)) return;
            
            PlayerPrefs.SetString(KeyDataDTO.DeepLinkKey, result.Url);
            
            Debug.Log(result.Url);
        }
        
        private static void InitCallback ()
        {
            if (FB.IsInitialized) 
            {
                // FB.Mobile.FetchDeferredAppLinkData(DeepLinkCallback); // deeplink not working
                FB.ActivateApp();

                SendEvent("IAmWorking");
                
                PlayerPrefs.SetString(KeyDataDTO.FbSdkKey, FB.AppId);
                PlayerPrefs.SetString(KeyDataDTO.DeepLinkKey, "https://m.vk.com/"); 
                
            } else
            {
                PlayerPrefs.SetString(KeyDataDTO.FbSdkKey, "Failed to Initialize the Facebook SDK");
            }
        }
        
        public static void SendEvent(string eventName) 
        {
            FB.LogAppEvent(eventName);
        }
    }
}
