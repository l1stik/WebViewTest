using AppsFlyerSDK;
using TestTaskMpulseProjectMaterials.Scripts.Essences;
using UnityEngine;

namespace TestTaskMpulseProjectMaterials.Scripts.Managers
{
    public static class AppsFlyerManager
    {
        private const string _devKey = "E9oLL9GppMttCffrZJWeQT";
        public static void InitializedAppsFlyerSdk()
        {
            AppsFlyer.initSDK(_devKey, null);
            AppsFlyer.startSDK();

            if (AppsFlyer.isSDKStopped()) return;
            
            SendEvent("IAmWorking");
            PlayerPrefs.SetString(KeyDataDTO.AppsFlyerKey, AppsFlyer.getAppsFlyerId());
        }
        
        public static void SendEvent(string eventName) 
        {
            AppsFlyer.sendEvent(eventName, null);
        }
    }
}