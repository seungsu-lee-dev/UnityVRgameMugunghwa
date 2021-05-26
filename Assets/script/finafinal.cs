using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finafinal : MonoBehaviour
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
    void OnTriggerEnter(Collider _col)  // 트리거에 충돌이 되었을 때는 이 함수를 도출한다.
    {
        if (!isActivated)
        {

            if (_col.gameObject.name == "Player")
            {
                isActivated = true;
                //Destroy(go_trap);

                for (int i = 0; i < rigid.Length; i++)
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
