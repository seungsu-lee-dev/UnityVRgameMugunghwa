using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SpaceMode
{
    InUI,
    InCorridor,
    InMaze,
    InOver,
    InClear
}

public class GameManager : MonoBehaviour
{
    public SpaceMode SPACEMODE;
    public bool isEnemyAwake=false;
    public GameObject OverCanvas;
    public GameObject PauseCanvasGameObject;
    private static GameManager instance;
    // Start is called before the first frame update
    void Start()
    {
        //SPACEMODE = SpaceMode.InCorridor;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(SPACEMODE);
        //if (SPACEMODE == SpaceMode.InOver)
        //{
        //    //GameObject.FindWithTag("Player").GetComponent<SimpleCapsuleWithStickMovement>().enabled = false;
        //    //OverCanvas.SetActive(true);
        //}
        if(SPACEMODE != SpaceMode.InUI)
        {
            if (Input.GetButtonDown("XRI_Left_MenuButton"))
            {
                Debug.Log(SPACEMODE);
                GameObject.Find("Canvas").transform.FindChild("PauseCanvas").gameObject.SetActive(true);
                GameObject.Find("PauseCanvas").transform.FindChild("GameObject").GetComponent<PauseCanvas>().SPACEMODE = SPACEMODE;
                //PauseCanvasGameObject.GetComponent<PauseCanvas>().SPACEMODE=SPACEMODE;
                GameObject.Find("Player").GetComponent<SimpleCapsuleWithStickMovement>().enabled = false;
                SPACEMODE = SpaceMode.InUI;
                Time.timeScale = 0.0f;
            }
        }
    }

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        
    }
}
