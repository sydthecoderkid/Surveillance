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
    
    private static bool purchasedoutfitone;

    private static bool purchasedoutfittwo;






  
    // Start is called before the first frame update
    void Start()
    {
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
        cooltextposition = originaltextpos.transform.position.x + 1.07f;
        spytextposition = originaltextpos.transform.position.x + 2.2f;
        orignialposition = originaltextpos.transform.position.x;

        if(Outfits.outfittwo){
           selecttext.transform.position = new Vector2(spytextposition, selecttext.transform.position.y);
        }
        else if(Outfits.outfitone){
            selecttext.transform.position = new Vector2(cooltextposition, selecttext.transform.position.y);
        }
        else{
           selecttext.transform.position = new Vector2(orignialposition, selecttext.transform.position.y);
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
         if(this.gameObject.name.Equals("Cool Button") && ShopCoins.totalcoins >= coinneeded){
           Outfits.outfitone = true;
           Outfits.baseoutfit = false;
           Outfits.outfittwo = false;
           coollock.SetActive(false);
           if(!purchasedoutfitone){
           ShopCoins.totalcoins -= coinneeded;
           }
               purchasedoutfitone = true;
               selecttext.transform.position = new Vector2(cooltextposition, selecttext.transform.position.y);
        }
        else if(this.gameObject.name.Equals("Spy Button") && ShopCoins.totalcoins  >= coinneeded){
             Outfits.outfitone = false;
           Outfits.baseoutfit = false;
           Outfits.outfittwo = true;
           spylock.SetActive(false);
           if(!purchasedoutfittwo){
           ShopCoins.totalcoins -= coinneeded;
           }
           purchasedoutfittwo = true;
             selecttext.transform.position = new Vector2(spytextposition, selecttext.transform.position.y);

        }
        else{
             Outfits.outfitone = false;
           Outfits.baseoutfit = true;
           Outfits.outfittwo = false;
           selecttext.transform.position = new Vector2(orignialposition, selecttext.transform.position.y);
        }
	}
}
