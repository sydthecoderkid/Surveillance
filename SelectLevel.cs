using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectLevel : MonoBehaviour
{
    private string thisname;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = this.gameObject.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
        thisname = this.gameObject.name;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void TaskOnClick(){
        PlayerHealth.movementenabled = true;
        PlayerHealth.playerdied = false;
        ShowTime.time = 0;
        LazerHit.hit = false;
      if(thisname.Equals("Level One")){
          SceneManager.LoadScene("Bankscene");
      }
       if(thisname.Equals("Level Two")){
          SceneManager.LoadScene("Level2");
      }
       if(thisname.Equals("Level Three")){
          SceneManager.LoadScene("Level3");
      }
       if(thisname.Equals("Level Four")){
          SceneManager.LoadScene("Level4");
      }
       
    }
}
