using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausemenu;
   
   public AudioSource pausemenunoise;
    public static bool pausemenuup;
    public GameObject volumebuton;
    public static int numclicks;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = this.gameObject.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
        pausemenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void TaskOnClick(){
          if(numclicks == 0){
            pausemenu.SetActive(true);
            PlayerHealth.movementenabled = false;
            pausemenuup = true;
            pausemenunoise.Play();
            numclicks++;
        }
        else if(numclicks == 1){
            pausemenu.SetActive(false);
            PlayerHealth.movementenabled = true;
            pausemenuup = false; 
            pausemenunoise.Play();
            numclicks=0;
        }

    }
}
