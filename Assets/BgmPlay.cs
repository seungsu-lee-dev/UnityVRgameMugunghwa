using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgmPlay : MonoBehaviour
{
    public AudioClip CorridorBgm;
    public AudioClip MazeBgm;
    public AudioClip SuzanBgm;
    public AudioClip ClearBgm;
    public AudioClip OverBgm;
    bool isOver = false;
    public GameObject Player;
    public SpaceMode SPACEMODE;

    public static AudioSource MusicPlay;
    // Start is called before the first frame update
    void Start()
    {
        MusicPlay = gameObject.AddComponent<AudioSource>();
        MusicPlay.mute = false;
        MusicPlay.loop = true;
        MusicPlay.playOnAwake = false;
        SPACEMODE = GameObject.Find("GameManager").GetComponent<GameManager>().SPACEMODE;

        if ((SPACEMODE == SpaceMode.InCorridor) || (SPACEMODE == SpaceMode.InUI))
        {
            playSound(CorridorBgm, MusicPlay);
            Debug.Log(SPACEMODE);
        }
        else if (SPACEMODE == SpaceMode.InOver)
        {
            playSound(OverBgm, MusicPlay);
            Debug.Log(SPACEMODE);
        }
        else if(SPACEMODE == SpaceMode.InClear)
        {
            playSound(ClearBgm, MusicPlay);
            Debug.Log(SPACEMODE);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isOver != true)
        {
            if (GameObject.Find("GameManager").GetComponent<GameManager>().SPACEMODE == SpaceMode.InOver)
            {
                isOver = true;
                playSound(OverBgm, MusicPlay);
            }
        }
    }

    void OnTriggerEnter(Collider _col)  // 트리거에 충돌이 되었을 때는 이 함수를 도출한다.
    {
        if (GameObject.Find("GameManager").GetComponent<GameManager>().SPACEMODE != SpaceMode.InMaze)
        {
            if (_col.gameObject.tag == "Tele")
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().SPACEMODE = SpaceMode.InMaze;
                playSound(MazeBgm, MusicPlay);
                Debug.Log("텔레");
            }
        }

        else
        {
            if (_col.gameObject.tag == "Enemy")
            {
                playSound(SuzanBgm, MusicPlay);
                Debug.Log(_col.gameObject.name);
            }
        }
    }

    void OnCollisionEnter(Collision _col)
    {
        if (_col.gameObject.name == "Goal")
        {
            playSound(ClearBgm, MusicPlay);
            Debug.Log("목표");
            return;
        }
    }

    public void playSound(AudioClip clip, AudioSource audioplayer)
    {
        audioplayer.Stop();
        audioplayer.clip = clip;
        audioplayer.loop = true;
        audioplayer.time = 0;
        audioplayer.Play();
    }

    public void SetMusicVolume(float volume)
    {
        MusicPlay.volume = volume;
    }

    void Awake()
    {
        //DontDestroyOnLoad(Player);
    }
}
