using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Outfits : MonoBehaviour
{
    public static bool baseoutfit = true;

    public static string outfitname = "null";

    public static bool outfitone = false;

    public static bool outfittwo = false;

    
    // Start is called before the first frame update
    void Start()
    { 
       

        
        
    }

    // Update is called once per frame
    void Update()
    {
       if(PlayerPrefs.GetString("outfit").Equals("baseoutfit")){
           baseoutfit = true;
           outfitone = false;
           outfittwo = false;
       }
        else if(PlayerPrefs.GetString("outfit").Equals("cooloutfit")){
           baseoutfit = false;
           outfitone = true;
           outfittwo = false;
       }
        else if(PlayerPrefs.GetString("outfit").Equals("spyoutfit")){
           baseoutfit = false;
           outfitone = false;
           outfittwo = true;
       }
    }

    public static void saveoutfit(string thisoutfit){

    }
}
