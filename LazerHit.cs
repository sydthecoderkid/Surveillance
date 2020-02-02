using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerHit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {         PlayerHealth.health -= 10;
         PlayerHealth.displayhealth -= 10;
         Debug.Log(PlayerHealth.health);

    }
   
}
