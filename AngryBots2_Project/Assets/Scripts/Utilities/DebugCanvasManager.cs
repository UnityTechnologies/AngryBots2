using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;
using UnityEngine.Experimental.Rendering.LightweightPipeline;

public class DebugCanvasManager : MonoBehaviour
{
    [Header("General References")]
    public Canvas debugWindow;
    public GameObject fpsDisplay;
    public GameObject postProcessingVolumes;

    

    [System.Serializable]
    public struct LWRPAssetSettings
    {
        public string qualityName;
        public LightweightRenderPipelineAsset qualityRenderPipelineAsset;
        public GameObject qualitySelectedDisplay;
        public string qualityInfo;
    }

    [Header("LWRP Asset Switch Settings")]
    public LWRPAssetSettings[] lwrpAssetSettings;
    private int currentLWRPAssetID = 2; // High
    public Text currentLWRPAssetInfo;

    void Start()
    {
        HideUI();
        
    }

    void HideUI()
    {
        debugWindow.enabled = false;
        fpsDisplay.SetActive(false);
        //LWRPLowDisplay.SetActive(false);
    }

    public void ToggleDebugWindow(bool newState)
    {
        debugWindow.enabled = newState;
    }

    public void ToggleFPSDisplay(bool newState)
    {
        fpsDisplay.SetActive(newState);
    }

    public void TogglePostProcessing(bool newState)
    {
        postProcessingVolumes.SetActive(newState);
    }

    public void SwitchLWRPAsset(int newAssetID)
    {

        //0 = Low - No Additional Lights, No Realtime Shadows, No HDR
        //1 = Medium - Additional Lights, No Realtime Shadows, HDR
        //2 = High - Additional Lights, Realtime Shadows, HDR

        GraphicsSettings.renderPipelineAsset = lwrpAssetSettings[newAssetID].qualityRenderPipelineAsset;
        UpdateLWRPAssetUI(newAssetID);
    }

    void UpdateLWRPAssetUI(int newAssetID)
    {
        lwrpAssetSettings[currentLWRPAssetID].qualitySelectedDisplay.SetActive(false);
        currentLWRPAssetID = newAssetID;
        lwrpAssetSettings[currentLWRPAssetID].qualitySelectedDisplay.SetActive(true);

        currentLWRPAssetInfo.text = lwrpAssetSettings[currentLWRPAssetID].qualityInfo;


    }


    
}
