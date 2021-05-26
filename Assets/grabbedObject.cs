using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grabbedObject : MonoBehaviour
{
    private bool grabbed;

    //public slot for you to place gripTrans via inspector
    public GameObject thing;

    private void Update()
    {
        grabbed = GetComponent<OVRGrabbable>().isGrabbed;
        if (grabbed == true)
        {

            //sets transform of grabbed object to chosen parents rotation & position transform.SetParent(thing.transform) ;
            transform.position = transform.parent.position;
            transform.rotation = transform.parent.rotation;
        }

        if (grabbed == false)
        {
            gameObject.transform.parent = null;
        }
    }
}