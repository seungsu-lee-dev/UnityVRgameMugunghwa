using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerState : MonoBehaviour
{
    public GameObject Player;

    void OnCollisionEnter(Collision _col)
    {
        if (GameObject.Find("GameManager").GetComponent<GameManager>().SPACEMODE == SpaceMode.InMaze)
        {
            if ((_col.gameObject.tag == "Enemy")||(_col.gameObject.tag == "Trap"))
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().SPACEMODE = SpaceMode.InOver;
                Debug.Log(GameObject.Find("GameManager").GetComponent<GameManager>().SPACEMODE);
                SceneManager.LoadScene("GameOverScene");
            }
            if (_col.gameObject.tag == "Goal")
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().SPACEMODE = SpaceMode.InClear;
                Debug.Log(GameObject.Find("GameManager").GetComponent<GameManager>().SPACEMODE);
                SceneManager.LoadScene("GameClearScene");
            }
        }
    }
}
