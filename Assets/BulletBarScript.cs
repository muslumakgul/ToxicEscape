using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletBarScript : MonoBehaviour
{
    public Slider slider; 

    public void SetMaxBulletAmount(int bulletAmount){
        slider.maxValue = bulletAmount;
        slider.value = bulletAmount;
    }

    public void setBulletAmount(int bulletAmount){
        slider.value = bulletAmount;
    }

}
