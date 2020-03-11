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
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void Save(){
      
    }
}
