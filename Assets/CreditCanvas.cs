using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CreditCanvas : MonoBehaviour
{
    //Text txt1;
    TextMeshProUGUI txt1;
    public GameObject Canvas;
    public GameObject ClearCanvas;
    // Start is called before the first frame update
    void Start()
    {
        txt1 = GameObject.Find("Text2").GetComponent<TextMeshProUGUI>();
        StartCoroutine(ShowCredit());
    }

    IEnumerator ShowCredit()
    {
        string[] stringArr = new string[] { "The Light of Escape:\nMonkey's Attack", "Directed by\nLee Seung Su", "Programmed by\nLee Seung Su" , "Graphic Designed by\nLee Dong hui" , "Programmed by\nLee Dong hui" , "Lead Programmed by\nPark Gyeong In" , "Programmed by\nLee Chi Hyoung" , "Thank you"};
        for (int index = 0; index < stringArr.Length; index++) {
            txt1.text = stringArr[index];
            txt1.material.color = new Vector4(1, 1, 1, 1);

            for (int i = 30; i <= 50; i++)
            {
                txt1.fontSize = i;
                //yield return new WaitForFixedUpdate();
                yield return new WaitForSeconds(0.1f);
            }

            //for(float z = 12.85; z >= -1.245; z++)
            //{
            //    pos = Canvas.GetComponent<RectTransform>();
            //    pos.Pos() 
            //}

            // Åõ¸íµµ
            for (float a = 1; a >= 0; a -= 0.01f)
            {
                txt1.material.color = new Vector4(1, 1, 1, a);
                yield return new WaitForFixedUpdate();
            }
        }
        NextCanvas();
    }

    void NextCanvas()
    {
        Canvas.SetActive(false);
        txt1.material.color = new Vector4(1, 1, 1, 1);
        ClearCanvas.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
