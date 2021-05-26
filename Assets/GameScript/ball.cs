using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public Rigidbody rigid;
    public SphereCollider col;
    public ParticleSystem explosion;
    public LayerMask m_LayerMask;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        col = GetComponent < SphereCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if(rigid.useGravity)
        {

            col.radius = 0.5f;
            col.isTrigger = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.transform.gameObject.layer == 8)
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

    }
}
