using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DisplayInfo : MonoBehaviour
{
    public static int coinnumber; 

    private int coincounter;

    private int totaltime;

    public int score;

     public Text coindisplay;
     
     public Text socredisplay;
     public Text timerdisplay;

     public GameObject timerholder;

     public GameObject scoreholder;

     public int timecounter;
   
     private float timer;

     private bool coinscounted;

     private bool timeshown;

     private bool scoreshown;

     public GameObject status;

      public Text statusdisplay;

     public static bool succeeded;


     public static bool failed;

     public Text takehomecoins;

     public static int takehomecoinsnum;

        public GameObject takehomecoinsholder;
     
    // Start is called before the first frame update
    void Start()
    {
        coinnumber = PlayerHealth.showncoins;
        totaltime = (int) ShowTime.time;
        takehomecoinsnum = (int) 0 + (coinnumber - LevelAmount.coinnumber); 
        ShopCoins.totalcoins = takehomecoinsnum;
        ShopCoins.setcoins();
        PlayerPrefs.Save();
     

    }

    // Update is called once per frame
    void Update()
    {
        
        timer += Time.deltaTime;
           coindisplay.text = ("X" + coincounter);
        if(coincounter < coinnumber && timer > 0.01f){
              coincounter++;
              timer = 0;
        }

        if(coinscounted){
            timerholder.SetActive(true);
             if(timecounter < totaltime && timer > 0.01f){
              timecounter++;
               timerdisplay.text = ("Time:" + timecounter);
              timer = 0;
              takehomecoinsholder.SetActive(true);
              if(!failed){
              takehomecoins.text = ("X" + (PlayerHealth.coins - LevelAmount.coinnumber));
              ShopCoins.totalcoins = takehomecoinsnum;
        
              }
              else{
                    takehomecoins.text = ("X" + 0);
              }

         }
        }


            scoreholder.SetActive(true);
            score = (totaltime + coinnumber);
               socredisplay.text = ("Score:" + score);
              timer = 0;
              scoreshown = true;
         

        
              if(coinnumber >= LevelAmount.coinnumber){
                  statusdisplay.color = Color.red;
                  succeeded = true;
                  statusdisplay.text = "STATUS: SUCCESS";
              }
               if(coinnumber < LevelAmount.coinnumber){
                  statusdisplay.color = Color.red;
                  failed = true;
                  statusdisplay.text = "STATUS: FAILURE";
              }
           status.SetActive(true);
        


        if(coincounter == coinnumber){
            coinscounted = true;
        }
        if(timecounter == totaltime){
            timeshown = true;
        }
        if(succeeded){
              PlayerHealth.coins = coinnumber;
         }
    }
}
