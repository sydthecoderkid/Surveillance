using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LazerHit : MonoBehaviour
{
    private GameObject lazer;

   private float timer2;
    public GameObject player;

    public static bool hit;

     public static bool playcoinsound;


     public static bool playlazersound;




  
    
    // Start is called before the first frame update
    void Start()
    {
        lazer = GetComponent<GameObject>();
        player = GameObject.Find("Robber");
    }

    // Update is called once per frame
    void Update()
    {

        
        if(timer2 >= 0.3f){
            playlazersound = false;
            hit = false;
            timer2 = 0;
        }
      if(!hit && player != null){
          player.GetComponent<SpriteRenderer>().color = UnityEngine.Color.white;
      }
      if(hit && player != null){
          timer2 +=Time.deltaTime;
            player.GetComponent<SpriteRenderer>().color = UnityEngine.Color.red;
      }
    }
    void OnCollisionEnter2D(Collision2D col)
    {   
        if(this.gameObject.name.Equals("Toplazer(Clone)") && col.collider.tag.Equals("Player")){      
        PlayerHealth.health -= 5;
         PlayerHealth.displayhealth -= 5;
            playlazersound = true;
            if(!UIShake.shook){
            UIShake.shakeUI();
            }
            ChangeHealthColor.changecolor();
            ChangeTextColor.changecolor();
         hit =true;
         timer2 = 0;
        
    }
    else if(this.gameObject.name.Equals("Coin") ||  this.gameObject.name.Equals("Coin(Clone)")){      
        if (col.collider.tag.Equals("Player")){
        PlayerHealth.coins+=1f;
         playcoinsound = true;
        Destroy(this.gameObject);
        }
    }
    else if(col.collider.tag.Equals("Colldier")){
        Destroy(lazer);
       }

    }

    
    
    
   
}
