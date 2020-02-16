using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    // Start is called before the first frame update
   void Start () {
		Button btn = this.gameObject.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

    // Update is called once per frame
    void Update()
    {
        
    }
    void TaskOnClick(){
	  SceneManager.LoadScene("MainMenu"); 
    }
}
