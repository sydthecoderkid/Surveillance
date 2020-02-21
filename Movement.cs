using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public static GameObject player; 
    public static float playerx;
    public static float playery;

    public static bool gamestarted = false;

    public static float playerspeed;


    // Start is called before the first frame update
    void Start()
    {
        playerx = transform.position.x;
        playery = transform.position.y;
        player = this.gameObject;
      player.transform.position = new Vector2(playerx, playery);
      playerspeed = 1.5f;
    }

    // Update is called once per frame if(Input.GetKey( KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
           
    
    void Update()
    {
      if(PlayerHealth.movementenabled){
        if(!gamestarted && Input.GetKey( KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
            startgame();
        }

        if(Input.GetKey( KeyCode.D) && !OutofBounds.rightwall || Input.GetKey(KeyCode.RightArrow) && !OutofBounds.rightwall){
            moveright();
        }
          if(Input.GetKey(KeyCode.UpArrow) && !OutofBounds.topwall|| Input.GetKey(KeyCode.W) && !OutofBounds.topwall || Input.GetKey(KeyCode.Space) && !OutofBounds.topwall){
            moveup();
        }
          if(Input.GetKey(KeyCode.DownArrow) && !OutofBounds.bottomwall|| Input.GetKey(KeyCode.S)&& !OutofBounds.bottomwall){
          player.transform.position = new Vector2(playerx, playery);
           playery -= (playerspeed * Time.deltaTime);
        }
         if(Input.GetKey(KeyCode.LeftArrow) && !OutofBounds.leftwall|| Input.GetKey(KeyCode.A) && !OutofBounds.leftwall){
           player.transform.position = new Vector2(playerx, playery);
           playerx -= (playerspeed * Time.deltaTime);
        }
      }
    
    }
    public static void startgame(){
        gamestarted = true;
    }

    public static void moveright(){
          player.transform.position = new Vector2(playerx, playery);
           playerx += (playerspeed * Time.deltaTime);
    }
    public static void moveup(){
      if(!OutofBounds.topwall){
      player.transform.position = new Vector2(playerx, playery);
           playery += (playerspeed * Time.deltaTime);
      }
    }

    public static void movedown(){
      if(!OutofBounds.bottomwall){
       player.transform.position = new Vector2(playerx, playery);
           playery -= (playerspeed * Time.deltaTime);
      }
    }

    
   
}
