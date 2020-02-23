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

     public static float playerspeedup;




    // Start is called before the first frame update
    void Start()
    {
        playerx = transform.position.x;
        playery = transform.position.y;
        player = this.gameObject;
      player.transform.position = new Vector2(playerx, playery);
      playerspeed = 1.5f;
      playerspeedup = 2f;

    }

    // Update is called once per frame if(Input.GetKey( KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
           
    
    void Update()
    { 
      if(PlayerHealth.movementenabled){
       if(Input.GetKey(KeyCode.D)){
         move_right();
       }
       if(Input.GetKey(KeyCode.A)){
        move_left();
       }
        if(Input.GetKey(KeyCode.S)){
        move_down();
       }
        if(Input.GetKey(KeyCode.W)){
         move_up();
       }
      }
    }

    public static void move_right(){
      Movement.gamestarted = true;
       Vector3 oldPos = player.transform.position;
       float newXPos = oldPos.x + Movement.playerspeed * Time.deltaTime;
        player.transform.position = new Vector3(newXPos,oldPos.y,oldPos.z);
    }

     public static void move_up(){
       Movement.gamestarted = true;
       Vector3 oldPos = player.transform.position;
       float newYPos = oldPos.y + Movement.playerspeedup * Time.deltaTime;
        player.transform.position = new Vector3(oldPos.x,newYPos,oldPos.z);
    }

     public static void move_down(){
        Movement.gamestarted = true;
          Vector3 oldPos = player.transform.position;
       float newYPos = oldPos.y - Movement.playerspeedup * Time.deltaTime;
        player.transform.position = new Vector3(oldPos.x,newYPos,oldPos.z);
    }

     public static void move_left(){
         Movement.gamestarted = true;
       Vector3 oldPos = player.transform.position;
       float newXPos = oldPos.x - Movement.playerspeed * Time.deltaTime;
        player.transform.position = new Vector3(newXPos,oldPos.y,oldPos.z);
    }
   
}
