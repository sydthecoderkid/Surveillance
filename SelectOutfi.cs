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

        spylock = GameObject.Find("SpyLock");
         coollock = GameObject.Find("CoolLock");

        if(this.gameObject.name.Equals("Cool Button")){
            coinneeded = 10;
        }
        else if(this.gameObject.name.Equals("Spy Button")){
            coinneeded = 15;
            
        }
    
    if(Outfits.outfitname.Equals("baseoutfit")){
           selecttext.transform.position = new Vector2(orignialposition, selecttext.transform.position.y);
      }
      if(Outfits.outfitname.Equals("cooloutfit")){
           selecttext.transform.position = new Vector2(cooltextposition, selecttext.transform.position.y);
      }
      else if(Outfits.outfitname.Equals("spyoutfit")){
           selecttext.transform.position = new Vector2(spytextposition, selecttext.transform.position.y);
      }
         
    }

    // Update is called once per frame
    void Update()
    {
        
        if(purchasedoutfittwo){
            spylock.SetActive(false);
        }
        if(purchasedoutfitone){
            coollock.SetActive(false);
        }

    }
    void TaskOnClick(){
        if(this.gameObject.name.Equals("Cool Button")&& ShopCoins.totalcoins >= coinneeded ||this.gameObject.name.Equals("Cool Button")&& purchasedoutfitone){
            selecttext.transform.position = new Vector2(cooltextposition, selecttext.transform.position.y);
            PlayerPrefs.SetString("oufit", "cooloutfit");
            if(!purchasedoutfitone){
            ShopCoins.totalcoins -= coinneeded;
            }
            PlayerPrefs.SetInt("coins", ShopCoins.totalcoins);
            purchasedoutfitone = true;
            Outfits.outfitone = true;
            Outfits.outfitname = "cooloutfit";
    }    

    if(this.gameObject.name.Equals("Spy Button") && ShopCoins.totalcoins >= coinneeded || this.gameObject.name.Equals("Spy Button") &&purchasedoutfittwo){
            selecttext.transform.position = new Vector2(spytextposition, selecttext.transform.position.y);
            PlayerPrefs.SetString("oufit", "spyoutfit");
            if(!purchasedoutfittwo){
            ShopCoins.totalcoins -= coinneeded;
            }
            PlayerPrefs.SetInt("coins", ShopCoins.totalcoins);
            purchasedoutfittwo = true;
            Outfits.outfittwo = true;
            Outfits.outfitone = false;
            Outfits.baseoutfit = false;
             Outfits.outfitname = "spyoutfit";
    }  

    else if(this.gameObject.name.Equals("Base Button")){
        selecttext.transform.position = new Vector2(orignialposition, selecttext.transform.position.y);
            PlayerPrefs.SetString("oufit", "baseoutfit");
            Outfits.baseoutfit = true;
            Outfits.outfitone = false;
            Outfits.outfittwo = false;
             Outfits.outfitname = "baseoutfit";
       }  

       PlayerPrefs.Save();
    }
}
