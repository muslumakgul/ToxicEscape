using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leveldoorforlevel1 : MonoBehaviour
{
    public GameObject level1door;
    private bool isOpen = false;
    public PlayAgain playAgain;
    
    void Start()
    {
        
    }
    
    public void levelUp()
    {
        Color customColor = new Color32(0xE6, 0xFF, 0x00, 0xFF);
        gameObject.GetComponent<SpriteRenderer>().color = customColor;
        isOpen = true;
    }
    
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player" && isOpen)
        {
            playAgain.LevelUp();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
