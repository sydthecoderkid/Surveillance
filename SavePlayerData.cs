using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePlayerData : MonoBehaviour
{
      public static int totalcoins;
      public static string outfitname;

      public static int totalunlockedlevels;
    // Start is called before the first frame update
    void Start()
    {
        totalcoins = ShopCoins.totalcoins;
        totalunlockedlevels = UnlockLevels.totalunlockedlevels;
        if(Outfits.baseoutfit){
            outfitname = "baseoutfit";
        }
        else if(Outfits.outfitone){
            outfitname = "cooloutfit";
        }
        else if (Outfits.outfittwo){
            outfitname = "spyoutfit";
        }

        

    }

    // Update is called once per frame
    void Update()
    {
        if(Outfits.baseoutfit){
           
        }
        else if(Outfits.outfitone){
            outfitname = "cooloutfit";
        }
        else{
            outfitname = "spyoutfit";
        }
        Save();
    }

    public static void Save(){
        PlayerPrefs.SetInt("coins", totalcoins);
        PlayerPrefs.SetString("outfit", outfitname);
        PlayerPrefs.SetInt("totalunlockedlevels", totalunlockedlevels);
        PlayerPrefs.Save();
    }
}
