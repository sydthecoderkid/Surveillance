using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Continue : MonoBehaviour
{
    public GameObject menu;
    // Start is called before the first frame update
    void Start()
    {
         Button btn = this.gameObject.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void TaskOnClick(){

         menu.SetActive(false);
            PlayerHealth.movementenabled = true;
            PauseMenu.pausemenuup = false; 
            PauseMenu.numclicks = 0;
     }
}
