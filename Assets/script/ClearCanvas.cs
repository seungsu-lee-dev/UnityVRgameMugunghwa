using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearCanvas : MonoBehaviour
{
    public GameObject Retry_button;
    public GameObject Setting_button;
    public GameObject Exit_button;
    public GameObject Canvas;
    public GameObject SettingCanvas;
    public GameObject SettingCanvasGameObject;
    public GameObject Player;

    
    public void OnClickRetry()
    {
        SceneManager.LoadScene("MugunghwaScene");
        GameObject.Find("GameManager").GetComponent<GameManager>().SPACEMODE = SpaceMode.InUI;
    }

    public void OnClickSetting()
    {
        Canvas.SetActive(false);
        SettingCanvas.SetActive(true);
        SettingCanvasGameObject.GetComponent<SettingCanvas>().Previous = PreviousCanvasState.Clear;
    }
    public void OnClickExit()
    {
        Application.Quit();
    }
}
