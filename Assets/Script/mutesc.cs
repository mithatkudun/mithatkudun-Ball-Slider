using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mutesc : MonoBehaviour
{
    public AudioSource audiosource;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void mute()
    {
        if (audiosource.isPlaying)
            audiosource.Pause();
        else
            audiosource.Play();


    }
}
