using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEditor.Experimental.UIElements;
using UnityEngine.Experimental.UIElements.StyleEnums;
using Object = UnityEngine.Object;
using UnityEngine.Experimental.Rendering.LightweightPipeline;

public class LWRPAssetSwitcherEditor : EditorWindow
{
    [MenuItem("Tools/LWRP Asset Switcher")]
    public static void ShowExample()
    {
        var window = GetWindow<LWRPAssetSwitcherEditor>();
        window.minSize = new Vector2(320, 320);
        window.titleContent = new GUIContent("LWRP Asset Switcher");
    }


    VisualElement m_VisualElementContainer;

    public void OnEnable()
    {
        var root = this.GetRootVisualContainer();

        var LWRPAssetInputs = new VisualElement()
        {
            style =
            {
                flexDirection = FlexDirection.Row,
            }
        };
        
    
        LWRPAssetInputs.Add(new Label()
        {
            text = "High Quality:"
                
        });

        LWRPAssetInputs.Add(new ObjectField()
        {
            objectType = typeof(LightweightRenderPipelineAsset),
            style = 
            {
                width = 300
            }
                
        });

        LWRPAssetInputs.Add(new Toggle()
        {

        });

        root.Add(LWRPAssetInputs);
              
    }

}
