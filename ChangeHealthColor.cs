using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeHealthColor : MonoBehaviour
{
    public static SpriteRenderer render; 
    public static Color32 currentcolor;
    // Start is called before the first frame update
    void Start()
    {
     render = this.GetComponent<SpriteRenderer>();
     currentcolor = render.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void changecolor(){
        if(PlayerHealth.displayhealth < 100 && PlayerHealth.displayhealth % 10 == 0){
            currentcolor.g -= (byte) 25;
            currentcolor.r += (byte) 25;
             render.color = currentcolor;
        }
    }
}
