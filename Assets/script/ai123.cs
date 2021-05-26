
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
using UnityEngine.AI;
 
public class ai123 : MonoBehaviour
{

    NavMeshAgent nav;
    GameObject target;
    SphereCollider sc;
    bool ActiveMode = false;
    public bool isActive=false;
    public GameObject GameManager;
    // Use this for initialization
    void Start()
    {
        sc = GetComponent<SphereCollider>();
        nav = GetComponent<NavMeshAgent>();
        target = GameObject.Find("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!ActiveMode) { return; }
        if (!isActive) {nav.SetDestination(transform.position); isActive=true; return; }
        if (nav.destination != target.transform.position)
        {
            nav.SetDestination(target.transform.position);
        }
        else
        {
            nav.SetDestination(transform.position);
        }
    }
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ActiveMode = true;
            GameManager.GetComponent<GameManager>().isEnemyAwake = true;
            if (GameManager.GetComponent<GameManager>().SPACEMODE == SpaceMode.InMaze)
            {
                sc.radius = 1;
            }
        }
    }
    
}


