using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpletrack : MonoBehaviour
{
    private Rigidbody[] rigid;
    [SerializeField] private GameObject go_trap;
    [SerializeField] private int damage;

    private bool isActivated = false;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponentsInChildren<Rigidbody>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!isActivated)
        {
            if(other.transform.tag != "Untagged")
            {
                isActivated = true;
                //Destroy(go_trap);

                for (int i =0; i< rigid.Length; i++)
                {
                    rigid[i].useGravity = true;
                    rigid[i].isKinematic = false;
                }
                

                
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
