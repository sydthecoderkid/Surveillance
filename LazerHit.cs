using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerHit : MonoBehaviour
{
    private GameObject lazer;
    // Start is called before the first frame update
    void Start()
    {
        lazer = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {   
        if(this.gameObject.name.Equals("Toplazer(Clone)") && col.collider.tag.Equals("Player")){      
        PlayerHealth.health -= 5;
         PlayerHealth.displayhealth -= 5;
         Debug.Log(PlayerHealth.health);
    }
    else if(this.gameObject.name.Equals("Coin") ||  this.gameObject.name.Equals("Coin(Clone)")){      
        if (col.collider.tag.Equals("Player")){
        PlayerHealth.coins+=0.5f;
        Destroy(this.gameObject);
        }
    }
    else if(col.collider.tag.Equals("Colldier")){
        Destroy(lazer);
       }

    }
    
   
}
