using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public static int health = 100 ;
     public  static int displayhealth = 100;
    public static bool  movementenabled = true;
    // Start is called before the first frame update
    void Start()
    {
        health = 100;
        displayhealth = health;
    }

    

    // Update is called once per frame
    void Update()
    {
        displayhealth = health;
        if(health <= 0 ){
            death();
        }
        displayhealth = health;
    }

    public static void death(){
       movementenabled = false;
    }
}
