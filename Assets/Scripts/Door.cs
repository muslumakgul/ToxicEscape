using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private bool isOpen = false; // Kapının açık veya kapalı olduğunu takip eden bir değişken

    public void OpenDoor()
    {
        // Kapıyı aç
        // Örneğin, animasyon oynatılabilir veya kapı GameObject'inin etkinlik durumu değiştirilebilir
        // Bu örnekte, GameObject'in etkinlik durumu değiştiriliyor
        gameObject.SetActive(false);
        isOpen = true;
    }

    public bool IsOpen()
    {
        return isOpen;
    }
}
