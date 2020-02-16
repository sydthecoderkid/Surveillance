using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject player; 
    public static float playerx;
    public float playery;

    public static bool gamestarted = false;

    private float playerspeed;


    // Start is called before the first frame update
    void Start()
    {
        playerx = transform.position.x;
        playery = transform.position.y;
      player.transform.position = new Vector2(playerx, playery);
      playerspeed = 2.5f;
    }

    // Update is called once per frame if(Input.GetKey( KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
           
    
    void Update()
    {
      if(PlayerHealth.movementenabled){
        if(!gamestarted && Input.GetKey( KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
            startgame();
        }

        if(Input.GetKey( KeyCode.D) && !OutofBounds.rightwall || Input.GetKey(KeyCode.RightArrow) && !OutofBounds.rightwall){
            player.transform.position = new Vector2(playerx, playery);
           playerx += (playerspeed * Time.deltaTime);
        }
          if(Input.GetKey(KeyCode.UpArrow) && !OutofBounds.topwall|| Input.GetKey(KeyCode.W) && !OutofBounds.topwall || Input.GetKey(KeyCode.Space) && !OutofBounds.topwall){
           player.transform.position = new Vector2(playerx, playery);
           playery += (playerspeed * Time.deltaTime);
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
    public void startgame(){
        gamestarted = true;
    }
   
}
