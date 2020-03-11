using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectOutfi : MonoBehaviour
{
    public Text selecttext;

    public Text originaltextpos;
    private static float spytextposition;

    private static float cooltextposition;

     private static float orignialposition;

    private int coinneeded;

    public GameObject spylock;

    public GameObject coollock;
    
    public static bool purchasedoutfitone;

    public static bool purchasedoutfittwo;







  
    // Start is called before the first frame update
    void Start()
    {
          cooltextposition = originaltextpos.transform.position.x + 1.07f;
        spytextposition = originaltextpos.transform.position.x + 2.2f;
        orignialposition = originaltextpos.transform.position.x;

         Button btn = this.gameObject.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);

        //Outfits.outfitname = PlayerPrefs.GetString("outfit");

        spylock = GameObject.Find("SpyLock");
         coollock = GameObject.Find("CoolLock");

        if(this.gameObject.name.Equals("Cool Button")){
            coinneeded = 10;
        }
        else if(this.gameObject.name.Equals("Spy Button")){
            coinneeded = 15;
            
        }
    
    if(PlayerPrefs.GetString("outfit").Equals("baseoutfit")){
           selecttext.transform.position = new Vector2(orignialposition, selecttext.transform.position.y);
           PlayerPrefs.SetString("outfit","baseoutfit");
      }
      if(PlayerPrefs.GetString("outfit").Equals("cooloutfit")){
           selecttext.transform.position = new Vector2(cooltextposition, selecttext.transform.position.y);
           purchasedoutfitone = true;
          PlayerPrefs.SetString("outfit", "cooloutfit");
      }
       if(PlayerPrefs.GetString("outfit").Equals("spyoutfit")){
           purchasedoutfittwo = true;
           selecttext.transform.position = new Vector2(spytextposition, selecttext.transform.position.y);
                 PlayerPrefs.SetString("outfit","spyoutfit"); 
      }
         Debug.Log(PlayerPrefs.GetString("outfit"));
          
    }

    // Update is called once per frame
    void Update()
    {
          PlayerPrefs.Save();
        if(purchasedoutfittwo || purchasedoutfitone){
            spylock.SetActive(false);
        }
        if(purchasedoutfitone ||purchasedoutfittwo){
            coollock.SetActive(false);
        }

    }
    void TaskOnClick(){
        if(this.gameObject.name.Equals("Cool Button")&& ShopCoins.totalcoins >= coinneeded ||this.gameObject.name.Equals("Cool Button")&& purchasedoutfitone){
            selecttext.transform.position = new Vector2(cooltextposition, selecttext.transform.position.y);
            if(!purchasedoutfitone){
            ShopCoins.totalcoins -= coinneeded;
            }
            PlayerPrefs.SetInt("coins", ShopCoins.totalcoins);
            purchasedoutfitone = true;
            Outfits.baseoutfit = false;
            Outfits.outfitone = true;
            Outfits.outfittwo = false;
            Outfits.outfitname = "cooloutfit";
              
    }    

    

    if(this.gameObject.name.Equals("Spy Button") && ShopCoins.totalcoins >= coinneeded || this.gameObject.name.Equals("Spy Button") &&purchasedoutfittwo){
             selecttext.transform.position = new Vector2(spytextposition, selecttext.transform.position.y);
            if(!purchasedoutfittwo){
            ShopCoins.totalcoins -= coinneeded;
            }
            PlayerPrefs.SetInt("coins", ShopCoins.totalcoins);
            purchasedoutfittwo = true;
            Outfits.baseoutfit = false;
            Outfits.outfittwo = true;
            Outfits.outfitone = false;
            Outfits.outfitname = "spyoutfit";
            PlayerPrefs.SetString("outfit", "spyoutfit");
           
    }  

     if(this.gameObject.name.Equals("Base Button")){
        selecttext.transform.position = new Vector2(orignialposition, selecttext.transform.position.y);
            Outfits.baseoutfit = true;
            Outfits.outfitone = false;
            Outfits.outfittwo = false;
             Outfits.outfitname = "baseoutfit";
              PlayerPrefs.SetString("outfit", "baseoutfit");
       }  

       
    }
}
