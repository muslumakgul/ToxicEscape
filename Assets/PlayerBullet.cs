using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{

    public int setMaxBulletAmount = 15;
    public int currentBulletAmount;
    public BulletBarScript bulletBar;


    // Start is called before the first frame update
    void Start()
    {
        currentBulletAmount = setMaxBulletAmount;
        bulletBar.SetMaxBulletAmount(setMaxBulletAmount);
    }
    
    // void Start()
    // {
    //     currentBulletAmount = PlayerData.Instance.bulletCount;
    //     bulletBar.SetMaxBulletAmount(setMaxBulletAmount);
    //     bulletBar.setBulletAmount(currentBulletAmount);
    // }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            if(currentBulletAmount > 0){
                DecreaseBulletAmount(1);
            }
        }
    }


    void DecreaseBulletAmount(int decrease){
        currentBulletAmount -= decrease;
        bulletBar.setBulletAmount(currentBulletAmount);
    }
}