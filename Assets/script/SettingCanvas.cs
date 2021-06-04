using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PreviousCanvasState
{
    Start,
    Pause,
    Clear
}

public class SettingCanvas : MonoBehaviour
{
    public GameObject Back_button;
    public GameObject Canvas;
    public GameObject StartCanvas;
    public GameObject PauseCanvas;
    public GameObject ClearCanvas;
    public PreviousCanvasState Previous;

    public void print()
    {
        Debug.Log("SettingCanvasOn");
    }

    public void OnClickBack()
    {
        Canvas.SetActive(false);
        if (Previous == PreviousCanvasState.Start)
            StartCanvas.SetActive(true);
        else if (Previous == PreviousCanvasState.Pause)
            PauseCanvas.SetActive(true);
        else if (Previous == PreviousCanvasState.Clear)
            ClearCanvas.SetActive(true);

        Debug.Log("Back");
    }
}
