using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject Exit_button;
    public GameObject Start_button;
    public GameObject Canvas;
    public GameObject GameManager;

    void Start()
    {
    }

    public void OnClickRetry()
    {
        SceneManager.LoadScene("MugunghwaScene");
        GameObject.Find("GameManager").GetComponent<GameManager>().SPACEMODE = SpaceMode.InUI;
    }

    public void OnClickExit()
    {
        Application.Quit();
    }
}
