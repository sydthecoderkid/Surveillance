using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPlayerData : MonoBehaviour
{
    public static int totallevelsunlocked = 0;

    private static bool firstload;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("totalunlockedlevels")){
            totallevelsunlocked = PlayerPrefs.GetInt("totalunlockedlevels");
        }

        if(firstload){
            Outfits.baseoutfit = true;
            Outfits.outfitone = false;
            Outfits.outfittwo = false;
            
        }
        
        Load();
 
    }

    // Update is called once per frame
    void Update()
    {
       /// Load();
    }

    private void Load(){
       if(PlayerPrefs.HasKey("coins")){
         
       }

      
       if(totallevelsunlocked == 1){
           UnlockLevels.leveltwounlocked = true;
           UnlockLevels.leveltwolock.SetActive(false);
       }
       else if(totallevelsunlocked == 2){
            UnlockLevels.leveltwounlocked = true;
            UnlockLevels.leveltwolock.SetActive(false);
            UnlockLevels.levelthreelock.SetActive(false);
       }

       else if(totallevelsunlocked == 3){
            UnlockLevels.leveltwounlocked = true;
            UnlockLevels.levelthreeunlocked = true;
             UnlockLevels.levelfourunlocked = true;
            UnlockLevels.leveltwolock.SetActive(false);
            UnlockLevels.levelthreelock.SetActive(false);
              UnlockLevels.levelfourlock.SetActive(false);
            
       }
      
    
        
    }
}
