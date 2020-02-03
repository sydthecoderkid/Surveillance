using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject player; 
    public static float playerx;
    public float playery;

    public static bool gamestarted = false;
    // Start is called before the first frame update
    void Start()
    {
        playerx = transform.position.x;
        playery = transform.position.y;
      player.transform.position = new Vector2(playerx, playery);
    }

    // Update is called once per frame if(Input.GetKey( KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
           
    
    void Update()
    {
        if(!gamestarted && Input.GetKey( KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
            startgame();
        }
        if(!OutofBounds.hitwall){
        if(Input.GetKey( KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
            player.transform.position = new Vector2(playerx, playery);
           playerx += (1.5f * Time.deltaTime);
        }
          if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.Space)){
           player.transform.position = new Vector2(playerx, playery);
           playery += (1.5f * Time.deltaTime);
        }
          if(Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)){
          player.transform.position = new Vector2(playerx, playery);
           playery -= (1.5f * Time.deltaTime);
        }
         if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)){
           player.transform.position = new Vector2(playerx, playery);
           playerx -= (1.5f * Time.deltaTime);
        }
     }
    
    }
    public void startgame(){
        gamestarted = true;
    }
   
}
