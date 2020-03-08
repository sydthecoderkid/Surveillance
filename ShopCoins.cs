using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShopCoins : MonoBehaviour
{
    public Text cointext;

    public static int totalcoins = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cointext.text = ("" + totalcoins);
    }
}
