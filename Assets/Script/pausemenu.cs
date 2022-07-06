using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class pausemenu : MonoBehaviour
{   public adsshow adsshow;
    public GameObject panel;
    public GameObject pausebutton;
    public static int reklamcounter;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (reklamcounter >= 3)
        {
            adsshow.ShowInterstitialAd();
        }
    }
    public void PauseButton()
    {
        Time.timeScale = 0f;
        panel.gameObject.SetActive(true);
        pausebutton.gameObject.SetActive(false);
    }
    public void Restart()
    {
        reklamcounter++;
       
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
       

    }
    public void Resume()
    {
        Time.timeScale = 1f;
        panel.gameObject.SetActive(false);
        pausebutton.gameObject.SetActive(true);
    }
    public void mainmenu()
    {
        reklamcounter++;
        SceneManager.LoadScene("mainmenu");
    }
    public void mutesound()
    {

    }

}
