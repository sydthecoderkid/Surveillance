using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelAmount : MonoBehaviour
{
    public static int coinnumber =10;
    public static string currentscene;

    public static string currentlevel;
    // Start is called before the first frame update
    void Start()
    {
        currentscene = SceneManager.GetActiveScene().name;
        if(currentscene.Equals("MainMenu")){
             currentlevel = "MainMenu";
        }
        if(currentscene.Equals("BankScene")){
             coinnumber = 10;
             Tempmove.movespeed = 1.25f;
             currentlevel = "BankScene";
        }
        if(currentscene.Equals("Level2")){
             coinnumber = 15;
              Tempmove.movespeed = 1.5f;
               currentlevel = "Level2";
        }
          if(currentscene.Equals("Level3")){
             coinnumber = 20;
              Tempmove.movespeed = 1.75f;
                currentlevel = "Level3";
        }
        if(currentscene.Equals("Level4")){
             coinnumber = 2;
              Tempmove.movespeed = 2f;
                currentlevel = "Level4";
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
