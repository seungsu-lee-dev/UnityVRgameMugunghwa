using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingCanvas : MonoBehaviour
{
    public GameObject Back_button;
    public GameObject Canvas;
    public GameObject StartCanvas;


    public void print()
    {
        Debug.Log("SettingCanvasOn");
    }

    public void OnClickBack()
    {
        Canvas.SetActive(false);
        StartCanvas.SetActive(true);
        Debug.Log("Back");
    }
}
