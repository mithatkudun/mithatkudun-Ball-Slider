using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Makeup : MonoBehaviour
{
    public GameObject ball;
    public Camera Camera;
    public TimeManager TimeManager;
    public Light spotlightball;
    void Start()
    {
        
    }

     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Player")
        {
            TimeManager.DoSlowmotion();
            StopCoroutine("cameraback");
            StartCoroutine("cameramove");
            

        }
    }
    IEnumerator cameramove()
    {
        yield return new WaitForSeconds(0.01f);

        spotlightball.color = Color.white;
        StartCoroutine("cameraback");
    }
    IEnumerator cameraback()
    {
        StopCoroutine("cameramove");
        yield return new WaitForSeconds(0.2f);

        spotlightball.color = Color.cyan;

    }
    void Update()
    {
        
    }
}
