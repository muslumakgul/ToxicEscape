using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource backgroundSound; // Background müzik sesi
    public AudioSource shootSound; // Ateş etme sesi

    public void PlayBackgroundMusic()
    {
        if (backgroundSound != null)
        {
            backgroundSound.Play();
        }
    }

    public void StopBackgroundMusic()
    {
        if (backgroundSound != null)
        {
            backgroundSound.Stop();
        }
    }

    public void PlayShootSound()
    {
        if (shootSound != null)
        {
            shootSound.Play();
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
