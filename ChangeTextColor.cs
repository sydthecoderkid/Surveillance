using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTextColor : MonoBehaviour
{
    public static Text text;

     public static Color32 currentcolor;
      public static Color32 originalcolor;
    // Start is called before the first frame update
    void Start()
    {
        text = this.gameObject.GetComponent<Text>();
        currentcolor = text.color;
        originalcolor = currentcolor;
        
    }

    // Update is called once per frame
    void Update()
    {
     text.color = currentcolor;   
    }
    public static void changecolor(){
        if(PlayerHealth.displayhealth < 100 && PlayerHealth.displayhealth % 10 == 0){
            if(currentcolor.g != 17 && currentcolor.r != 253){
            currentcolor.g -= (byte) 25;
            currentcolor.r += (byte) 25;
            }
            
            if(PlayerHealth.playerdied){
                currentcolor = Color.red;
            }
        }
    }
}
