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
        PlayerHealth.displaycoins = PlayerHealth.coins;
         health = ("" + PlayerHealth.displayhealth);
         if(this.gameObject.name.Equals("DisplayCoins")){
             text.text =( "X " + PlayerHealth.showncoins);
         }
         
         else if(this.gameObject.name.Equals("Health")){
        text.text = health;
         }
    }
}
