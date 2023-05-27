using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalCheck : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col) //oncollisionenter karakterle düşmanın birbirine temas anı
    {
        if (col.gameObject.tag == "EnemyCastle") //eğer temas edenin tag'i player'sa
        {
            Debug.Log("SCORE +1");
            Destroy(gameObject);
        }
        else if(col.gameObject.tag == "OurCastle")
        {
            Debug.Log("SKORE -1");
            Destroy(gameObject);
        }
    }
}
