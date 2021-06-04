using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public enum SpaceMode
//{
//    InUI,
//    InCorridor,
//    InMaze,
//    InOver
//}

public class NewGameManager : MonoBehaviour
{
    public SpaceMode SPACEMODE;
    public bool isEnemyAwake = false;
    public GameObject Player;
    public GameObject OverCanvas;
    public bool isModeChange = true;
    // Start is called before the first frame update
    void Start()
    {
        SPACEMODE = SpaceMode.InUI;
        //SPACEMODE = SpaceMode.InCorridor;
    }

    // Update is called once per frame
    
    void Update()
    {

        if (SPACEMODE == SpaceMode.InOver)
        {
            if (isModeChange) //  이 안에 한번만 실행할 명령. 모드가 바뀌는 상황일때 이 스크립트의 isModeChange를 true로 바꾸어서 한번 실행할 수 있도록 한다.
            {
                Player.GetComponent<SimpleCapsuleWithStickMovement>().enabled = false;
                isModeChange = false;
            }
        }
        else if (SPACEMODE == SpaceMode.InCorridor)
        {
            if (isModeChange)
            {

            }
            else if (SPACEMODE == SpaceMode.InMaze)
            {
                if (isModeChange)
                {

                    isModeChange = false;
                }
            }
            else if (SPACEMODE == SpaceMode.InUI)
            {
                if (isModeChange)
                {

                    isModeChange = false;
                }
            }
        }

    }
}
