using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditCanvas : MonoBehaviour
{
    Text txt1;
    public GameObject Canvas;
    RectTransform pos;
    // Start is called before the first frame update
    void Start()
    {
        txt1 = GameObject.Find("Text1").GetComponent<Text>();
        StartCoroutine("ShowCredit");
    }

    IEnumerator ShowCredit()
    {
        txt1.text = "The Light of Escape:\nMonkey's Attack";
        txt1.material.color = new Vector4(1, 1, 1, 1);

        //for(int i = 1; i <= 20; i++)
        //{
        //    txt1.fontSize = i;
        //    yield return new WaitForFixedUpdate();
        //    //yield return new WaitForSeconds(1);
        //}

        //for(float z = 12.85; z >= -1.245; z++)
        //{
        //    pos = Canvas.GetComponent<RectTransform>();
        //    pos.Pos() 
        //}

        // Åõ¸íµµ
        for(float a = 1; a >= 0; a -= 0.01f)
        {
            txt1.material.color = new Vector4(1, 1, 1, a);
            yield return new WaitForFixedUpdate();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
