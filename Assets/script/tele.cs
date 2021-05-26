using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tele : MonoBehaviour
{
    public Transform Target;
   
   
    void OnTriggerEnter(Collider _col)  // 트리거에 충돌이 되었을 때는 이 함수를 도출한다.
    {
        
        if (_col.gameObject.tag == "Tele")
        {
            
            //while (true)
            //{
            //    if (ParentTransform.parent == null)
            //        break;
            //    else
            //        ParentTransform = ParentTransform.parent;
            //}

            transform.position = Target.position;
        
        }
    }
}
