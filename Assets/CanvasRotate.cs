using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasRotate : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SimpleCapsuleWithStickMovement>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
