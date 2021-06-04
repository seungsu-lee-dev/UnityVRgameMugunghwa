using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseCanvas : MonoBehaviour
{
    public GameObject Resume_button;
    public GameObject Retry_button;
    public GameObject Setting_button;
    public GameObject Exit_button;
    public GameObject Canvas;
    public GameObject SettingCanvas;
    public GameObject SettingCanvasGameObject;
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
    public void OnClickRetry()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("MugunghwaScene");
        GameObject.Find("GameManager").GetComponent<GameManager>().SPACEMODE = SpaceMode.InUI;
    }
    public void OnClickSetting()
    {
        Canvas.SetActive(false);
        SettingCanvas.SetActive(true);
        SettingCanvasGameObject.GetComponent<SettingCanvas>().Previous = PreviousCanvasState.Pause;
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
