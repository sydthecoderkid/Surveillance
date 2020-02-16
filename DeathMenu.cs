using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathMenu : MonoBehaviour
{
    public GameObject deathmenu;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerHealth.displaycoins >= LevelAmount.coinnumber){
            text.text = "Success";
        }
        else{
             text.text = "Failure";
        }
        if(PlayerHealth.health == 0){
            deathmenu.SetActive(true);
            
        }
    }
}
