using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPlayerData : MonoBehaviour
{
    public int totallevelsunlocked = 0;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("totalunlockedlevels")){
            totallevelsunlocked = PlayerPrefs.GetInt("totalunlockedlevels");
        }
        
        Load();
 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Load(){
       if(PlayerPrefs.HasKey("coins")){
         ShopCoins.totalcoins = PlayerPrefs.GetInt("coins");
       }

       if(PlayerPrefs.HasKey("outfit")){
           if(SavePlayerData.outfitname.Equals("baseoutfit")){
               Outfits.baseoutfit = true;
           }
           else if(SavePlayerData.outfitname.Equals("cooloutfit")){
               Outfits.outfitone = true;
           }
           else if(SavePlayerData.outfitname.Equals("spyoutfit")){
               Outfits.outfittwo = true;
           }
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
