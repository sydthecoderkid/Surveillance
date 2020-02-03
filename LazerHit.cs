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
        if(col.collider.tag.Equals("Player")){      
        PlayerHealth.health -= 5;
         PlayerHealth.displayhealth -= 5;
         Debug.Log(PlayerHealth.health);
    }
    else if(col.collider.tag.Equals("Colldier")){
        Destroy(lazer);
       }

    }
    
   
}
