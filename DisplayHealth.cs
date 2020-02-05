using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayHealth : MonoBehaviour
{
    public Text text;
    private string health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         health = ("Health: " + PlayerHealth.displayhealth);
         if(this.gameObject.name.Equals("Coins")){
             text.text =("Coins: " + PlayerHealth.displaycoins + "/" + LevelAmount.coinnumber);
         }
         else{
        text.text = health;
         }
    }
}
