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
        switch(thisname){
            case "Level One":
            
            SceneManager.LoadScene("Bankscene");
            break;

            case "Level Two":
            if(UnlockLevels.leveltwounlocked)
            SceneManager.LoadScene("Level2");
            break;

            case "Level Three":
             if(UnlockLevels.levelthreeunlocked)
            SceneManager.LoadScene("Level3");
            break;

            case "Level Four":
             if(UnlockLevels.levelfourunlocked)
            SceneManager.LoadScene("Level4");
            break;
        }
      
       
    }
}
