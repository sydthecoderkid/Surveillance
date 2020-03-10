using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShopCoins : MonoBehaviour
{
    public Text cointext;

    public static int totalcoins;

    public static int totalcoins2;
    // Start is called before the first frame update
    void Start()
    {
                Debug.Log(PlayerPrefs.GetInt("coins"));
       totalcoins = PlayerPrefs.GetInt("coins", totalcoins);
    }

    // Update is called once per frame
    void Update()
    {
    
        cointext.text = ("" + totalcoins);
    }

    public static void setcoins(){
        PlayerPrefs.SetInt("coins", totalcoins);
        PlayerPrefs.Save();
        Debug.Log(PlayerPrefs.GetInt("coins"));
    }
}
