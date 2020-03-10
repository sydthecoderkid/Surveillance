using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ToggleVolume : MonoBehaviour
{
    public bool toggeled;
    public GameObject audioholder;

    public GameObject striker;
    // Start is called before the first frame update
    void Start()
    {
        toggeled = true;
          Button btn = this.gameObject.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TaskOnClick(){
	   if(!toggeled){
           audioholder.SetActive(true);
           toggeled = true;
            striker.SetActive(false);
       }
       else if(toggeled){
           audioholder.SetActive(false);
           toggeled = false;
           striker.SetActive(true);
       }
	}
}
