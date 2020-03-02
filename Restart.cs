﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Restart : MonoBehaviour
{
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
       Movement.gamestarted = false;
        PlayerHealth.movementenabled = true;
        PlayerHealth.showncoins = 0;
        PauseMenu.pausemenuup = false;
        ShowTime.time = 0;
        LazerHit.hit = false;
        SceneManager.LoadScene(LevelAmount.currentlevel);
    }
}
