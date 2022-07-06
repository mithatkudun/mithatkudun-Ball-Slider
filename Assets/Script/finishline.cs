using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class finishline : MonoBehaviour
{
    public BallControl BallControl;
    public GameObject ball;
    public TextMeshProUGUI tekrar;
    public static int tekrarsayisi;
    public static int highscore;
   
    public TextMeshProUGUI highscoree;
   

    void Start()
    {
        
        tekrarsayisi = 0;
        highscore = PlayerPrefs.GetInt("highscore", highscore);
    }

     void OnTriggerEnter2D(Collider2D  other)
    {
        if (other.transform.tag == "Player")
        {
            StartCoroutine("finisher");
        }
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.transform.tag == "Player")
        {
            StopCoroutine("finisher");
        }
        
    }
    void Update()
    {
        tekrar.text = tekrarsayisi.ToString();
        highscoree.text = "HighScore = " + highscore.ToString();
        if (tekrarsayisi > highscore) { 
        highscore = tekrarsayisi;
        tekrar.text = "" + tekrarsayisi;
        
        PlayerPrefs.SetInt("highscore", highscore);
        }

    }
   
    IEnumerator sansyenile()
    {
        yield return new WaitForSeconds(0.5f);
        BallControl.sanssayisi= 3;
    }
    IEnumerator finisher()
    {
        yield return new WaitForSeconds(4f);
        Vector3 temp = new Vector3(0, Random.Range(-8, 8), 0);
        transform.position = temp;
        StartCoroutine("sansyenile");
        tekrarsayisi++;

    }
    public static void AddPoints(int pointsToAdd)
    {
        tekrarsayisi += pointsToAdd;
    }

    public static void Reset()
    {
        tekrarsayisi = 0;
    }
}
