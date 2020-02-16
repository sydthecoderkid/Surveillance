using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausemenu;
   
   public AudioSource pausemenunoise;
    public static bool pausemenuup;
    private int numclicks;
    // Start is called before the first frame update
    void Start()
    {
        pausemenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("escape") && numclicks == 0){
            pausemenu.SetActive(true);
            PlayerHealth.movementenabled = false;
            pausemenuup = true;
            pausemenunoise.Play();
            numclicks++;
        }
        else if(Input.GetKeyDown("escape") && numclicks == 1){
            pausemenu.SetActive(false);
            PlayerHealth.movementenabled = true;
            pausemenuup = false; 
            pausemenunoise.Play();
            numclicks=0;
        }

    }
}
