using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ChangetoLevels : MonoBehaviour
{
  public Button yourButton;

	void Start () {
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

    // Update is called once per frame
    void Update()
    {
        
    }
     void TaskOnClick(){
	  SceneManager.LoadScene("LevelSelection");
	}
}
