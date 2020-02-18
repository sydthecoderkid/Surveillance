using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UnlockLevels : MonoBehaviour
{
    public GameObject leveltwolock;
    public GameObject levelthreelock;

    public GameObject levelfourlock;

    private bool leveltwounlocked;
    private bool levelthreeunlocked;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(DisplayInfo.succeeded){
          if(LevelAmount.playlevel.Equals("BankScene")){
              leveltwolock.SetActive(false);
          }
          if(LevelAmount.playlevel.Equals("Level2")){
              levelthreelock.SetActive(false);
               leveltwolock.SetActive(false);
          }
          if(LevelAmount.playlevel.Equals("Level3")){
              levelfourlock.SetActive(false);
               levelthreelock.SetActive(false);
               leveltwolock.SetActive(false);
          }
        }
    }
}
