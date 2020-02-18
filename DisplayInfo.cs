using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DisplayInfo : MonoBehaviour
{
    public int coinnumber; 

    private int coincounter;

    private int totaltime;

    public int score;

     public Text coindisplay;
     
     public Text socredisplay;
     public Text timerdisplay;

     public GameObject timerholder;

     public GameObject scoreholder;

     public int timecounter;

     public int scorecounter;
   
     private float timer;

     private bool coinscounted;

     private bool timeshown;

     private bool scoreshown;

     public GameObject status;

      public Text statusdisplay;

     public static bool succeeded;


     public static bool failed;
     
    // Start is called before the first frame update
    void Start()
    {
        coinnumber =PlayerHealth.displaycoins;
        totaltime = (int) ShowTime.time;

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
         }
        }

        if(timeshown){
            scoreholder.SetActive(true);
            score = (totaltime + coinnumber);
             if(scorecounter < score && timer > 0){
              scorecounter++;
               socredisplay.text = ("Score:" + scorecounter);
              timer = 0;
              scoreshown = true;
         }

          if(scoreshown){
              if(coinnumber >= LevelAmount.coinnumber){
                  statusdisplay.color = Color.yellow;
                  succeeded = true;
                  statusdisplay.text = "STATUS: SUCCESS";
              }
               if(coinnumber < LevelAmount.coinnumber){
                  statusdisplay.color = Color.black;
                  failed = true;
                  statusdisplay.text = "STATUS: FAILURE";
              }
           status.SetActive(true);
         }
        }


        if(coincounter == coinnumber){
            coinscounted = true;
        }
        if(timecounter == totaltime){
            timeshown = true;
        }
    }
}
