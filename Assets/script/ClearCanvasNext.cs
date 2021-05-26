using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearCanvasNext : MonoBehaviour
{
    public GameObject Next_button;
    public GameObject Retry_button;
    public GameObject Setting_button;
    public GameObject Exit_button;
    public GameObject Canvas;
    public GameObject SettingCanvas;
    public GameObject Player;

    public void OnClickNext()
    {
        Canvas.SetActive(false);
        GameObject.Find("GameManager").GetComponent<GameManager>().SPACEMODE = SpaceMode.InUI;
        Player.GetComponent<SimpleCapsuleWithStickMovement>().enabled = true;
    }
    public void OnClickRetry()
    {
        SceneManager.LoadScene("su_testScene");
        GameObject.Find("GameManager").GetComponent<GameManager>().SPACEMODE = SpaceMode.InUI;
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
}
