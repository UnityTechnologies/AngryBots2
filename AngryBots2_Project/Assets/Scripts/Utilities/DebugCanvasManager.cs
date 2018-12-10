using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;
using UnityEngine.Experimental.Rendering.LightweightPipeline;

public class DebugCanvasManager : MonoBehaviour
{
    [Header("References")]
    public Canvas debugWindow;
    public GameObject fpsDisplay;
    public GameObject postProcessingVolumes;
    public GameObject LWRPLowDisplay;
    public GameObject LWRPHighDisplay;

    [Header("LWRP Assets")]
    public LightweightRenderPipelineAsset LWRPLowQualityAsset;
    public LightweightRenderPipelineAsset LWRPHighQualityAsset;

    void Start()
    {
        HideUI();
        
    }

    void HideUI()
    {
        debugWindow.enabled = false;
        fpsDisplay.SetActive(false);
        LWRPLowDisplay.SetActive(false);
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

        //0 = Low
        //1 = High

        switch(newAssetID)
        {
            case 0:
                GraphicsSettings.renderPipelineAsset = LWRPLowQualityAsset;
                LWRPLowDisplay.SetActive(true);
                LWRPHighDisplay.SetActive(false);
                break;

            case 1:
                GraphicsSettings.renderPipelineAsset = LWRPHighQualityAsset;
                LWRPLowDisplay.SetActive(false);
                LWRPHighDisplay.SetActive(true);
                break;
        }
    }


    
}
