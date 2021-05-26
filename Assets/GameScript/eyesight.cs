using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class eyesight : MonoBehaviour
{
    public LayerMask m_LayerMask;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void sight()
    {
        Collider[] cols = Physics.OverlapSphere(transform.position, 30f, m_LayerMask);
        if (cols.Length > 0)
        {

            Transform[] enemy = new Transform[cols.Length];
            for (int i = 0; i < cols.Length; i++)
            {

                enemy[i] = cols[i].transform;
                Vector3 t_dir = (enemy[i].position - transform.position).normalized;
                float t_angle = Vector3.Angle(t_dir, transform.forward);

                if (t_angle < 75)
                {
                    //RaycastHit[] hits = Physics.RaycastAll(transform.position, t_dir);
                    if (Physics.Raycast(transform.position, t_dir, out RaycastHit hit))
                    {

                        //Debug.DrawRay(transform.forward, t_dir * hit.distance, Color.red);
                        
                        if (hit.transform.tag == "Enemy")
                        {   
                           //Debug.Log(hit.transform.name+ t_angle);
                            hit.transform.gameObject.GetComponent<ai123>().isActive = false;
                        }
                    }
                    
                }
                
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        sight();
        
    }
    public void GameOver()
    {
        SceneManager.LoadScene("GameOverScene");
        //Debug.Log("½ÇÇàµÊ");
    }
}
