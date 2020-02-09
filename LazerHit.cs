using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerHit : MonoBehaviour
{
    private GameObject lazer;

   private float timer2;
    public GameObject player;

    private bool hit;
    
    // Start is called before the first frame update
    void Start()
    {
        lazer = GetComponent<GameObject>();
        player = GameObject.Find("Robber");
    }

    // Update is called once per frame
    void Update()
    {
        timer2 += Time.deltaTime;
        if(hit){
          if(timer2 >= 0.3f){
             player.GetComponent<SpriteRenderer>().color = UnityEngine.Color.white;
             }
              else{
                player.GetComponent<SpriteRenderer>().color = UnityEngine.Color.red;
              }
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {   
        if(this.gameObject.name.Equals("Toplazer(Clone)") && col.collider.tag.Equals("Player")){      
        PlayerHealth.health -= 5;
         PlayerHealth.displayhealth -= 5;
         displayhit();
    }
    else if(this.gameObject.name.Equals("Coin") ||  this.gameObject.name.Equals("Coin(Clone)")){      
        if (col.collider.tag.Equals("Player")){
        PlayerHealth.coins+=0.5f;
        Destroy(this.gameObject);
        }
    }
    else if(col.collider.tag.Equals("Colldier")){
        Destroy(lazer);
       }

    }

    public void displayhit(){
       hit = true;
       timer2 = 0;
    }
    
   
}
