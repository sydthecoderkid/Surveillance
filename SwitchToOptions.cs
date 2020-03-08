using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SwitchToOptions : MonoBehaviour
{
    // Start is called before the first frame update
     public Button yourButton;
     public GameObject buttonone, buttontwo, back, volume, restartbutton, continuebutton;

     public GameObject options;

     
    void Start () {
		Button btn = this.gameObject.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
        options.SetActive(false);
       
	}

    // Update is called once per frame
    void Update()
    {
      
    }
    void TaskOnClick(){
        buttonone.SetActive(false);
        buttontwo.SetActive(false);
        volume.SetActive(true);
        options.SetActive(true);
        continuebutton.SetActive(false);
        restartbutton.SetActive(false);
        this.gameObject.SetActive(false);
        back.SetActive(true);
       
    }
}
