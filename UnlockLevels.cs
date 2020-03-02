using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UnlockLevels : MonoBehaviour
{
    public static GameObject leveltwolock;
    public static GameObject levelthreelock;

    public static GameObject levelfourlock;

    public static bool leveltwounlocked;
    public static bool levelthreeunlocked;

     public static bool levelfourunlocked;
    // Start is called before the first frame update
    void Start()
    {
        leveltwolock = GameObject.Find("Lock 2");
        levelthreelock = GameObject.Find("Lock 3");
         levelfourlock = GameObject.Find("Lock 4");
    }

    // Update is called once per frame
    void Update()
    {
        if(DisplayInfo.succeeded){
          if(LevelAmount.playlevel.Equals("BankScene")){
              leveltwounlocked = true;
              leveltwolock.SetActive(false);
          }
          if(LevelAmount.playlevel.Equals("Level2")){
              levelthreeunlocked = true;
              levelthreelock.SetActive(false);
              leveltwounlocked = true;
              leveltwolock.SetActive(false);

          }
          if(LevelAmount.playlevel.Equals("Level3")){
              levelfourunlocked = true;
              levelfourlock.SetActive(false);
               levelthreeunlocked = true;
              levelthreelock.SetActive(false);
              leveltwounlocked = true;
              leveltwolock.SetActive(false);
          }
        }
    }
}
