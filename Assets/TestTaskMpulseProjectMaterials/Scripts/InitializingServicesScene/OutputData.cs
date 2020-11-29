using System;
using TestTaskMpulseProjectMaterials.Scripts.Essences;
using UnityEngine;
using UnityEngine.UI;

namespace TestTaskMpulseProjectMaterials.Scripts.InitializingServicesScene
{
    public class OutputData
        : MonoBehaviour
    {
        [SerializeField]
        private Text _textOutput;
        
        public void ShowDataOutput()
        {
            try
            {
                var valueLog = 
                    "FbSdk log" + 
                    Environment.NewLine +
                    PlayerPrefs.GetString(KeyDataDTO.FbSdkKey) +
                    Environment.NewLine
                    + 
                    "DEEP_LINK" + 
                    Environment.NewLine + 
                    PlayerPrefs.GetString(KeyDataDTO.DeepLinkKey) +
                    Environment.NewLine
                    + 
                    "AppsFlyer log" + 
                    Environment.NewLine + 
                    PlayerPrefs.GetString(KeyDataDTO.AppsFlyerKey) +
                    Environment.NewLine
                    +
                    "Location_KEY log" + 
                    Environment.NewLine + 
                    PlayerPrefs.GetString(KeyDataDTO.LocationKey);
            
                _textOutput.text = valueLog;
            }
            catch (Exception e)
            {
                _textOutput.text = e.Message;
                throw;
            }
        }
    }
}