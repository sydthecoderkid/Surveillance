using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutofBounds : MonoBehaviour
{
    public static bool hitwall;
    public static bool topwall;

    public static bool bottomwall;
     public static bool leftwall;

    public static bool rightwall;


    // Start is called before the first frame update
    void Start()
    {
      topwall = false;
      rightwall = false;
      bottomwall = false;
      leftwall = false;
    }


 
    
    // Update is called once per frame
    void Update()
    {
        
    }
     void OnCollisionEnter2D(Collision2D col)
    {
     if(this.gameObject.name.Equals("Wall3")){
         topwall = true;
         bottomwall = false;
     }
    else if(this.gameObject.name.Equals("Wall4")){
         topwall = false;
         bottomwall = true;
     }
     else if(this.gameObject.name.Equals("Wall1")){
        leftwall = true;
        rightwall = false;
     }
     else if(this.gameObject.name.Equals("Wall2")){
         leftwall = false;
        rightwall = true;
     }
    }
    private void OnCollisionExit2D(Collision2D col)
    {
           leftwall = false;
           rightwall = false;
           topwall = false;
           bottomwall = false;
    }

      

    
}