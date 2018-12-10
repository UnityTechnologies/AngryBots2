/* To Toggle on and off the FPS Canvas

Editor - Click anywhere in the Game View
On a touch-screen Device - Hold one finger on the screen and tap with a second finger

*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleCanvas : MonoBehaviour
{
    public Canvas canvas;
    private bool canvasVisible = false;


    void Start()
    {
        canvas.enabled = canvasVisible;
    }

    void Update()
    {
       int fingerCount = 0;

       foreach(Touch touch in Input.touches)
       {
           if(touch.phase == TouchPhase.Began)
           {
               fingerCount++;
           }
       }

       if(fingerCount > 0)
       {
           ToggleCanvasVisibility();
       }

        if(Input.GetMouseButtonDown(0))
        {
            ToggleCanvasVisibility();
        }
    }

    void ToggleCanvasVisibility()
    {
        canvasVisible = !canvasVisible;
        canvas.enabled = canvasVisible;
    }
}
