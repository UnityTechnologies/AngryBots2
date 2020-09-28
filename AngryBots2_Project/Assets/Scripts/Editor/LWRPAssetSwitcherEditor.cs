using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.UIElements;
using UnityEngine.Rendering.Universal;

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
        var root = rootVisualElement;

        var urpAssetInputs = new VisualElement()
        {
            style =
            {
                flexDirection = FlexDirection.Row,
            }
        };
        
    
        urpAssetInputs.Add(new Label()
        {
            text = "High Quality:"
                
        });

        urpAssetInputs.Add(new ObjectField()
        {
            objectType = typeof(UniversalRenderPipelineAsset),
            style = 
            {
                width = 300
            }
        });

        urpAssetInputs.Add(new Toggle()
        {

        });

        root.Add(urpAssetInputs);
    }

}
