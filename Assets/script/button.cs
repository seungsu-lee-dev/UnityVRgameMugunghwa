using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public GameObject Start_button;
    public GameObject Setting_button;
    public GameObject Exit_button;
    public GameObject Canvas;
    public GameObject SettingCanvas;
    public GameObject GameManager;
    public GameObject Player;
    private bool isPause = false;

    
    void Update()
    {
        //Time.timeScale = 0.0f;
    }

    public void OnClickStart()
    {
        //times();
        Canvas.SetActive(false);
        GameObject.Find("GameManager").GetComponent<GameManager>().SPACEMODE = SpaceMode.InCorridor;
        Player.GetComponent<SimpleCapsuleWithStickMovement>().enabled = true;
    }
    public void OnClickSetting()
    {
        Canvas.SetActive(false);
        SettingCanvas.SetActive(true);
    }
    public void OnClickExit()
    {
        Application.Quit();
    }

    //public void times()
    //{
    //    Time.timeScale = 1.0f;
    //}
}
