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

        GraphicsSettings.renderPipelineAsset = lwrpAssetSettings[newAssetID].qualityRenderPipelineAsset;
        UpdateLWRPAssetUI(newAssetID);

    }

    void UpdateLWRPAssetUI(int newAssetID)
    {

        lwrpAssetSettings[currentLWRPAssetID].qualitySelectedDisplay.SetActive(false);
        currentLWRPAssetID = newAssetID;
        lwrpAssetSettings[currentLWRPAssetID].qualitySelectedDisplay.SetActive(true);

        
        LightweightRenderPipelineAsset asset = GraphicsSettings.renderPipelineAsset as LightweightRenderPipelineAsset;

        string assetInfoString =
            "HDR: " + asset.supportsHDR;

        currentLWRPAssetInfo.text = assetInfoString;

    }


    
}
