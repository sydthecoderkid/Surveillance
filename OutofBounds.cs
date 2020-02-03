using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutofBounds : MonoBehaviour
{
    public static bool hitwall;


    // Start is called before the first frame update
    void Start()
    {
      
    }


 
    
    // Update is called once per frame
    void Update()
    {
        
    }
     void OnCollisionEnter2D(Collision2D col)
    {
     hitwall = true;          
    }
    void OnCollisionExit2D(Collision2D col)
    {
     hitwall = false;          
    }
}