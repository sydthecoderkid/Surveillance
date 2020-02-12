using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelAmount : MonoBehaviour
{
    public static int coinnumber =10;
    public static string currentscene;
    // Start is called before the first frame update
    void Start()
    {
        currentscene = SceneManager.GetActiveScene().name;
        if(currentscene.Equals("BankScene")){
             coinnumber = 10;
             Tempmove.movespeed = 1.25f;
        }
        if(currentscene.Equals("Level2")){
             coinnumber = 15;
              Tempmove.movespeed = 1.5f;
        }
          if(currentscene.Equals("Level3")){
             coinnumber = 20;
              Tempmove.movespeed = 1.75f;
        }
        if(currentscene.Equals("Level4")){
             coinnumber = 25;
              Tempmove.movespeed = 2f;
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
