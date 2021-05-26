using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseCanvas : MonoBehaviour
{
    public GameObject Resume_button;
    public GameObject Setting_button;
    public GameObject Exit_button;
    public GameObject Canvas;
    public GameObject SettingCanvas;
    public GameObject GameManager;
    public GameObject Player;
    public SpaceMode SPACEMODE;
    // Start is called before the first frame update
    void Awake()
    {
        SPACEMODE = SpaceMode.InUI;
    }
    void Start()
    {
        
        //Canvas.SetActive(false);




    }

    public void OnClickResume()
    {
        GameObject.Find("GameManager").GetComponent<GameManager>().SPACEMODE = SPACEMODE;
        Canvas.SetActive(false);
        Player.GetComponent<SimpleCapsuleWithStickMovement>().enabled = true;
        times();
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

    public void times()
    {
        Time.timeScale = 1.0f;
    }
}
