using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelAmount : MonoBehaviour
{
    public static int coinnumber =10;
    // Start is called before the first frame update
    void Start()
    {
        if(SceneManager.GetActiveScene().name.Equals("BankScene")){
             coinnumber = 35;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
