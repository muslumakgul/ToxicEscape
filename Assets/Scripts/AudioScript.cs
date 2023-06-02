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
    public AudioSource goalSound;
    public AudioSource pongSound;
    public AudioSource mumbleSound;
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
        shootSound.Play();
    }

    public void PlayDamageSound()
    {
        
        damageSound.Play();
        
    }

    public void PlayGameOverSound()
    {
        
        gameoverSound.Play();
        

    }

    public void PlayCoinSound()
    {
        
        coinSound.Play();
        
    }

    public void PlayKeySound()
    {
        
        keySound.Play();
        
    }
    
    public void PongSound()
    {
        
        pongSound.Play();
        
    }

    public void playGoalSound()
    {
        
        goalSound.Play();
        
    }
    
    public void PlayMumbleNPCSound()
    {
        
        mumbleSound.Play();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
