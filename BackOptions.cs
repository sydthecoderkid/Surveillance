using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackOptions : MonoBehaviour
{
    public GameObject buttonone, buttontwo, buttonthree, back, volume, continuebutton;

    public GameObject pausetext, optionstext;
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
        buttonone.SetActive(true);
        buttontwo.SetActive(true);
        buttonthree.SetActive(true);
        pausetext.SetActive(true);
         continuebutton.SetActive(true);
        volume.SetActive(false);
        back.SetActive(false);
        optionstext.SetActive(false);
       
    }
}
