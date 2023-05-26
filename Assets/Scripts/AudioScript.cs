using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource backgroundSound; // Background müzik sesi
    public AudioSource shootSound; // Ateş etme sesi
    public AudioSource damageSound;
    public AudioSource gameoverSound;
    public AudioSource coinSound;
    public AudioSource keySound;
    
    // public void PlayBackgroundMusic()
    // {
    //     if (backgroundSound != null)
    //     {
    //         backgroundSound.Play();
    //     }
    // }
    void Start()
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

    public void PlayDamageSound()
    {
        if (damageSound != null)
        {
            damageSound.Play();
        }
    }

    public void PlayGameOverSound()
    {
        if (gameoverSound != null)
        {
            gameoverSound.Play();
        }

    }

    public void PlayCoinSound()
    {
        if (coinSound != null)
        {
            coinSound.Play();
        }
    }

    public void PlayKeySound()
    {
        if (keySound != null)
        {
            keySound.Play();
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
