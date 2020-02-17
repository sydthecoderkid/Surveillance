using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTextColor : MonoBehaviour
{
    public static Text text;

     public static Color32 currentcolor;
    // Start is called before the first frame update
    void Start()
    {
        text = this.gameObject.GetComponent<Text>();
        currentcolor = text.color;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void changecolor(){
        if(PlayerHealth.displayhealth < 100 && PlayerHealth.displayhealth % 10 == 0){
            currentcolor.g -= (byte) 25;
            currentcolor.r += (byte) 25;
             text.color = currentcolor;
        }
    }
}
