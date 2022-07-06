using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class BallControl : MonoBehaviour
{
    public adsshow adsshow;
    public TextMeshProUGUI sans;
    Touch touch;
    public float power = 15f;
    public float maxDrag = 5f;
    public LineRenderer lr;
    public Rigidbody2D rb;
    Vector3 dragStartPos;
    public static int sanssayisi;
    public TextMeshProUGUI hitordont;
    public Button tryagain;
    public Button Continue;
    public pausemenu pausemenu;
    






    private void Start()
    {
        sanssayisi = 3;
        Time.timeScale = 1f;
    }

    public void Update()
    {
        sans.text = " X " + sanssayisi.ToString();
        if (rb.IsSleeping() == true)
        {
            BallPower();
            hitordont.text = "Hit".ToString();
            hitordont.color = Color.green;
        }
        else
        {
            hitordont.text = "Wait".ToString();
            hitordont.color = Color.red;
        }

        if (sanssayisi < 0)
        {
            Time.timeScale = 0f;
            if (rb.IsSleeping() == true)
            StartCoroutine("sanssifir");          
        }
        if(sanssayisi>0)
        {
            Time.timeScale = 1f;
        }

    }
    IEnumerator sanssifir()
    {
        
        
        
        Time.timeScale = 0f;
        tryagain.gameObject.SetActive(true);
        Continue.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.1f);
    }
    public void sanssifirdevam()
    {
        Time.timeScale = 1f;
        tryagain.gameObject.SetActive(false);
        Continue.gameObject.SetActive(false);
    }
    public void tryagainn()
    {
        Time.timeScale = 1f;
        pausemenu.reklamcounter++;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
    public void continuee()
    {
        
        Time.timeScale = 1f;
        adsshow.ShowRewardedVideo();

    }
    void DragStart()
    {
        dragStartPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,15.5f));
        dragStartPos.z = -1f;
        sanssayisi--;
        lr.positionCount = 1;
        lr.SetPosition(0, dragStartPos);
    }
    void Dragging()
    {
        Vector3 draggingPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 15.5f));
        draggingPos.z = -1f;
        lr.positionCount = 2;
        lr.SetPosition(1, draggingPos);
        
    }
    void DragRelease()
    {
        lr.positionCount = 0;
        Vector3 dragReleasePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 15.5f));
        dragReleasePos.z = -1f;

        Vector3 force = dragStartPos - dragReleasePos;
        Vector3 clampedForce = Vector3.ClampMagnitude(force, maxDrag) * power;
        rb.AddForce(clampedForce, ForceMode2D.Impulse);
       
    }
    void BallPower()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            DragStart();
        }
        if (Input.GetMouseButton(0))
        {
            Dragging();
        }
        if (Input.GetMouseButtonUp(0))
        {
            DragRelease();
        }
    }

}

