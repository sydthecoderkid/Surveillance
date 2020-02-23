using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelAmount : MonoBehaviour
{
    public static int coinnumber =10;
    public static string currentscene;

    public static string currentlevel;

     public static string playlevel;

     public static float spawnspeed;
    // Start is called before the first frame update
    void Start()
    {
         if(!(SceneManager.GetActiveScene().name.Equals("Debrief"))){
        currentscene = SceneManager.GetActiveScene().name;
         }
        if(currentscene.Equals("MainMenu")){
             currentlevel = "MainMenu";
        }
        if(currentscene.Equals("BankScene")){
             coinnumber = 10;
             Tempmove.movespeed = 1.25f;
             currentlevel = "BankScene";
             playlevel = "BankScene";
             spawnspeed =3f;
        }
        if(currentscene.Equals("Level2")){
             coinnumber = 15;
              Tempmove.movespeed = 1.3f;
               currentlevel = "Level2";
                 playlevel = "Level2";
                 spawnspeed = 2.7f;
        }
          if(currentscene.Equals("Level3")){
             coinnumber = 20;
              Tempmove.movespeed = 1.4f;
                currentlevel = "Level3";
               playlevel = "Level3";
               spawnspeed = 2.5f;
        }
        if(currentscene.Equals("Level4")){
             coinnumber = 25;
              Tempmove.movespeed = 1.5f;
                currentlevel = "Level4";
                playlevel = "Level4";
                spawnspeed = 2.3f;
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
