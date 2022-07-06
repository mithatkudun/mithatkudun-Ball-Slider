using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ColorChange : MonoBehaviour
{
    public finishline finishline;
    public GameObject zemin;
    public GameObject trigger;
    public Vector3 localScale;
    public TextMeshProUGUI tryagain;
    
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        if(finishline.tekrarsayisi>10)
        {
            zemin.GetComponent<Renderer>().material.color = Color.white;
            trigger.GetComponent<Renderer>().material.color = Color.red;
            trigger.gameObject.transform.localScale = new Vector3(9.1f,2.9f, 0.1f);

        }
        if (finishline.tekrarsayisi > 20)
        {
            zemin.GetComponent<Renderer>().material.color = Color.cyan;
            trigger.GetComponent<Renderer>().material.color = Color.grey;
            trigger.gameObject.transform.localScale = new Vector3(9.1f, 2.3f, 0.1f);
        }
        if (finishline.tekrarsayisi > 30)
        {
            zemin.GetComponent<Renderer>().material.color = Color.black;
            trigger.GetComponent<Renderer>().material.color = Color.white;
            trigger.gameObject.transform.localScale = new Vector3(9.1f, 1.7f, 0.1f);
        }
        if (finishline.tekrarsayisi > 40)
        {
            zemin.GetComponent<Renderer>().material.color = Color.red;
            trigger.GetComponent<Renderer>().material.color = Color.cyan;
            trigger.gameObject.transform.localScale = new Vector3(9.1f, 1.1f, 0.1f);
        }
        if (finishline.tekrarsayisi > 50)
        {
            zemin.GetComponent<Renderer>().material.color = Color.magenta;
            trigger.GetComponent<Renderer>().material.color = Color.white;
            trigger.gameObject.transform.localScale = new Vector3(9.1f, 1f, 0.1f);
        }
        if (finishline.tekrarsayisi > 60)
        {
            zemin.GetComponent<Renderer>().material.color = Color.green;
            trigger.GetComponent<Renderer>().material.color = Color.red;
            trigger.gameObject.transform.localScale = new Vector3(9.1f, 1f, 0.1f);
        }
        if (finishline.tekrarsayisi > 70)
        {
            zemin.GetComponent<Renderer>().material.color = Color.red;
            trigger.GetComponent<Renderer>().material.color = Color.green;
            trigger.gameObject.transform.localScale = new Vector3(9.1f, 1f, 0.1f);
        }
        if (finishline.tekrarsayisi > 80)
        {
            zemin.GetComponent<Renderer>().material.color = Color.white;
            trigger.GetComponent<Renderer>().material.color = Color.black;
            trigger.gameObject.transform.localScale = new Vector3(9.1f, 1f, 0.1f);
        }
        if (finishline.tekrarsayisi > 90)
        {
            zemin.GetComponent<Renderer>().material.color = Color.blue;
            trigger.GetComponent<Renderer>().material.color = Color.cyan;
            trigger.gameObject.transform.localScale = new Vector3(9.1f, 1f, 0.1f);
        }
        if (finishline.tekrarsayisi > 100)
        {
            zemin.GetComponent<Renderer>().material.color = Color.red;
            trigger.GetComponent<Renderer>().material.color = Color.yellow;
            trigger.gameObject.transform.localScale = new Vector3(9.1f, 2f, 0.1f);
        }
        if (finishline.tekrarsayisi > 110)
        {
            zemin.GetComponent<Renderer>().material.color = Color.white;
            trigger.GetComponent<Renderer>().material.color = Color.red;
            trigger.gameObject.transform.localScale = new Vector3(9.1f, 1.9f, 0.1f);
        }
        if (finishline.tekrarsayisi > 120)
        {
            zemin.GetComponent<Renderer>().material.color = Color.magenta;
            trigger.GetComponent<Renderer>().material.color = Color.grey;
            trigger.gameObject.transform.localScale = new Vector3(9.1f, 1.8f, 0.1f);
        }
        if (finishline.tekrarsayisi > 130)
        {
            zemin.GetComponent<Renderer>().material.color = Color.black;
            trigger.GetComponent<Renderer>().material.color = Color.white;
            trigger.gameObject.transform.localScale = new Vector3(9.1f, 1.7f, 0.1f);
        }
        if (finishline.tekrarsayisi > 140)
        {
            zemin.GetComponent<Renderer>().material.color = Color.red;
            trigger.GetComponent<Renderer>().material.color = Color.cyan;
            trigger.gameObject.transform.localScale = new Vector3(9.1f, 1.6f, 0.1f);
        }
        if (finishline.tekrarsayisi > 150)
        {
            zemin.GetComponent<Renderer>().material.color = Color.magenta;
            trigger.GetComponent<Renderer>().material.color = Color.white;
            trigger.gameObject.transform.localScale = new Vector3(9.1f, 1.5f, 0.1f);
        }
        if (finishline.tekrarsayisi > 160)
        {
            zemin.GetComponent<Renderer>().material.color = Color.green;
            trigger.GetComponent<Renderer>().material.color = Color.red;
            trigger.gameObject.transform.localScale = new Vector3(9.1f, 1.4f, 0.1f);
        }
        if (finishline.tekrarsayisi > 170)
        {
            zemin.GetComponent<Renderer>().material.color = Color.red;
            trigger.GetComponent<Renderer>().material.color = Color.green;
            trigger.gameObject.transform.localScale = new Vector3(9.1f, 1.3f, 0.1f);
        }
        if (finishline.tekrarsayisi > 180)
        {
            zemin.GetComponent<Renderer>().material.color = Color.white;
            trigger.GetComponent<Renderer>().material.color = Color.black;
            trigger.gameObject.transform.localScale = new Vector3(9.1f, 1.2f, 0.1f);
        }
        if (finishline.tekrarsayisi > 190)
        {
            zemin.GetComponent<Renderer>().material.color = Color.blue;
            trigger.GetComponent<Renderer>().material.color = Color.cyan;
            trigger.gameObject.transform.localScale = new Vector3(9.1f, 1.1f, 0.1f);
        }
        if (finishline.tekrarsayisi > 200)
        {
            zemin.GetComponent<Renderer>().material.color = Color.red;
            trigger.GetComponent<Renderer>().material.color = Color.yellow;
            trigger.gameObject.transform.localScale = new Vector3(9.1f, 2f, 0.1f);
        }
        if (finishline.tekrarsayisi > 210)
        {
            zemin.GetComponent<Renderer>().material.color = Color.white;
            trigger.GetComponent<Renderer>().material.color = Color.red;
            trigger.gameObject.transform.localScale = new Vector3(9.1f, 1.9f, 0.1f);
        }
        if (finishline.tekrarsayisi > 220)
        {
            zemin.GetComponent<Renderer>().material.color = Color.magenta;
            trigger.GetComponent<Renderer>().material.color = Color.grey;
            trigger.gameObject.transform.localScale = new Vector3(9.1f, 1.8f, 0.1f);
        }
        if (finishline.tekrarsayisi > 230)
        {
            zemin.GetComponent<Renderer>().material.color = Color.black;
            trigger.GetComponent<Renderer>().material.color = Color.white;
            trigger.gameObject.transform.localScale = new Vector3(9.1f, 1.7f, 0.1f);
        }
        if (finishline.tekrarsayisi > 240)
        {
            zemin.GetComponent<Renderer>().material.color = Color.red;
            trigger.GetComponent<Renderer>().material.color = Color.cyan;
            trigger.gameObject.transform.localScale = new Vector3(9.1f, 1.6f, 0.1f);
        }
        if (finishline.tekrarsayisi > 250)
        {
            zemin.GetComponent<Renderer>().material.color = Color.magenta;
            trigger.GetComponent<Renderer>().material.color = Color.white;
            trigger.gameObject.transform.localScale = new Vector3(9.1f, 1.5f, 0.1f);
        }
        if (finishline.tekrarsayisi > 260)
        {
            zemin.GetComponent<Renderer>().material.color = Color.green;
            trigger.GetComponent<Renderer>().material.color = Color.red;
            trigger.gameObject.transform.localScale = new Vector3(9.1f, 1.4f, 0.1f);
        }
        if (finishline.tekrarsayisi > 270)
        {
            zemin.GetComponent<Renderer>().material.color = Color.red;
            trigger.GetComponent<Renderer>().material.color = Color.green;
            trigger.gameObject.transform.localScale = new Vector3(9.1f, 1.3f, 0.1f);
        }
        if (finishline.tekrarsayisi > 280)
        {
            zemin.GetComponent<Renderer>().material.color = Color.white;
            trigger.GetComponent<Renderer>().material.color = Color.black;
            trigger.gameObject.transform.localScale = new Vector3(9.1f, 1.2f, 0.1f);
        }
        if (finishline.tekrarsayisi > 290)
        {
            zemin.GetComponent<Renderer>().material.color = Color.blue;
            trigger.GetComponent<Renderer>().material.color = Color.cyan;
            trigger.gameObject.transform.localScale = new Vector3(9.1f, 1.1f, 0.1f);
        }
        if (finishline.tekrarsayisi > 300)
        {
            zemin.GetComponent<Renderer>().material.color = Color.red;
            trigger.GetComponent<Renderer>().material.color = Color.yellow;
            trigger.gameObject.transform.localScale = new Vector3(9.1f, 1f, 0.1f);
        }

        if (finishline.tekrarsayisi > 310)
        {
            zemin.GetComponent<Renderer>().material.color = Color.white;
            trigger.GetComponent<Renderer>().material.color = Color.red;
            trigger.gameObject.transform.localScale = new Vector3(9.1f, 0.9f, 0.1f);
        }
        if (finishline.tekrarsayisi > 320)
        {
            zemin.GetComponent<Renderer>().material.color = Color.magenta;
            trigger.GetComponent<Renderer>().material.color = Color.grey;
            trigger.gameObject.transform.localScale = new Vector3(9.1f, 0.8f, 0.1f);
        }
        if (finishline.tekrarsayisi > 330)
        {
            zemin.GetComponent<Renderer>().material.color = Color.black;
            trigger.GetComponent<Renderer>().material.color = Color.white;
            trigger.gameObject.transform.localScale = new Vector3(9.1f, 0.7f, 0.1f);
        }
        if (finishline.tekrarsayisi > 340)
        {
            zemin.GetComponent<Renderer>().material.color = Color.red;
            trigger.GetComponent<Renderer>().material.color = Color.cyan;
            trigger.gameObject.transform.localScale = new Vector3(9.1f, 0.69f, 0.1f);
        }
        if (finishline.tekrarsayisi > 350)
        {
            zemin.GetComponent<Renderer>().material.color = Color.magenta;
            trigger.GetComponent<Renderer>().material.color = Color.white;
            trigger.gameObject.transform.localScale = new Vector3(9.1f, 0.68f, 0.1f);
        }
        if (finishline.tekrarsayisi > 360)
        {
            zemin.GetComponent<Renderer>().material.color = Color.green;
            trigger.GetComponent<Renderer>().material.color = Color.red;
            trigger.gameObject.transform.localScale = new Vector3(9.1f, 0.67f, 0.1f);
        }
        if (finishline.tekrarsayisi > 370)
        {
            zemin.GetComponent<Renderer>().material.color = Color.red;
            trigger.GetComponent<Renderer>().material.color = Color.green;
            trigger.gameObject.transform.localScale = new Vector3(9.1f, 0.67f, 0.1f);
        }
        if (finishline.tekrarsayisi > 380)
        {
            zemin.GetComponent<Renderer>().material.color = Color.white;
            trigger.GetComponent<Renderer>().material.color = Color.black;
            trigger.gameObject.transform.localScale = new Vector3(9.1f, 0.66f, 0.1f);
        }
        if (finishline.tekrarsayisi > 390)
        {
            zemin.GetComponent<Renderer>().material.color = Color.blue;
            trigger.GetComponent<Renderer>().material.color = Color.cyan;
            trigger.gameObject.transform.localScale = new Vector3(9.1f, 0.65f, 0.1f);
        }
        if (finishline.tekrarsayisi > 400)
        {
            zemin.GetComponent<Renderer>().material.color = Color.red;
            trigger.GetComponent<Renderer>().material.color = Color.yellow;
            trigger.gameObject.transform.localScale = new Vector3(9.1f, 0.6f, 0.1f);
        }


    }

}
