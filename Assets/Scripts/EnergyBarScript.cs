using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnergyBarScript : MonoBehaviour
{
    public Slider slider; // Start is called before the first frame update
    
    
    public void SetMaxEnergy(float energy){
        slider.maxValue = energy;
        slider.value = energy;
    }

    public void SetEnergy(int energy){
        slider.value = energy;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
