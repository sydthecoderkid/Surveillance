using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeToHighScores : MonoBehaviour
{
     public Button yourButton;
    void Start () {
		Button btn = this.gameObject.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

    // Update is called once per frame
    void Update()
    {
        
    }
     void TaskOnClick(){
	  SceneManager.LoadScene("HighScores");
	}
}
