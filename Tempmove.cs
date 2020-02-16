using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tempmove : MonoBehaviour
{
    
    public GameObject player; 
    public static float playerx;
    public float playery;

    public float xholder;

    public static bool gamestarted = false;
  
  public static float movespeed = 1.5f;
    public GameObject robber;
    // Start is called before the first frame update
    void Start()
    {
          playerx = transform.position.x;
          playery = transform.position.y;
      player.transform.position = new Vector2(playerx, playery);
     

    }

    // Update is called once per frame
    void Update()
    {
        if(Movement.gamestarted && PlayerHealth.movementenabled){
         player.transform.position = new Vector2(playerx, transform.position.y);
           playerx += (movespeed * Time.deltaTime);
        }
        
    }
  void OnCollisionEnter2D(Collision2D col)
    {
         PlayerHealth.death();

    }
    
}
