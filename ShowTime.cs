using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowTime : MonoBehaviour
{
    public static float time;
    public Text timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerHealth.movementenabled){
        time += Time.deltaTime;
        }
        timer.text = "" + (int) time;
    }
}
