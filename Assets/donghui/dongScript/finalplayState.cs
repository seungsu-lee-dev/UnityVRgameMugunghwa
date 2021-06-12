using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finalplayState : MonoBehaviour
{
    public GameObject Player;
    public static AudioSource MusicPlay;
    
    public GameObject ovrcamerarig;
    public Animator ani;

    public GameObject deathPrefab;
    public GameObject blood;
    public GameObject[] hands;
    //public Animation Cam1;
    void Start()
    {
        ani = ovrcamerarig.GetComponent<Animator>();
        
    }

    void OnCollisionEnter(Collision _col)
    {
        if (GameObject.Find("GameManager").GetComponent<GameManager>().SPACEMODE == SpaceMode.InMaze)
        {
            if (_col.gameObject.tag == "Enemy" || _col.gameObject.tag == "Trap")
            {
                GameObject tempdeath = Instantiate(deathPrefab,Player.transform.position, Player.transform.rotation);
                GameObject tempBlood = Instantiate(blood, new Vector3(Player.transform.position.x, 0.8f, Player.transform.position.z), Player.transform.rotation);
                hands[0].SetActive(false);
                hands[1].SetActive(false);
                ani.enabled = true;
                ani.Play("realcame");
                if(_col.gameObject.name == "Needle")
                {
                    _col.gameObject.GetComponent<BoxCollider>().enabled = false;
                }
                GameObject.Find("GameManager").GetComponent<GameManager>().SPACEMODE = SpaceMode.InOver;
                Debug.Log(GameObject.Find("GameManager").GetComponent<GameManager>().SPACEMODE);
                //SceneManager.LoadScene("GameOverScene");

                //MusicPlay = GameManager.GetComponent<AudioSource>();
                //MusicPlay.mute = false;
                //MusicPlay.loop = true;
                //MusicPlay.playOnAwake = false;
                //Player.GetComponent<BgmPlay>().playSound(OverBgm, MusicPlay);
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
