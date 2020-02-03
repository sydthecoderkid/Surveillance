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
        if(Movement.gamestarted){
         player.transform.position = new Vector2(playerx, transform.position.y);
           playerx += (1.25f * Time.deltaTime);
        }
        
    }
  void OnCollisionEnter2D(Collision2D col)
    {
               Destroy(robber);
         PlayerHealth.death();

    }
}
