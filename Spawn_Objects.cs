using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Random;


public class Spawn_Objects : MonoBehaviour
{
    public GameObject wall1;
    public GameObject wall2;

    public GameObject toplaser;
    public GameObject bottomlaser;
        public GameObject topwall;
            public GameObject bottomwall;

            public GameObject coin;
    public float position;

      public float positiony;

    private float time;
     private float cointimer;

    public static System.Random random;


        public int bound1;
      public  int bound2;
        public int topbound;
       public  int bottombound;
    
    // Start is called before the first frame update
    void Start()
    {
     random = new System.Random();   
    }

    // Update is called once per frame
    void Update()
    {
        bound1 = (int)wall1.transform.position.x;
     bound2 = (int) wall2.transform.position.x;
     topbound = (int)topwall.transform.position.y;
     bottombound = (int) bottomwall.transform.position.y;
     
        time += Time.deltaTime;
        if(OnRender.objectsdestroyed && time >= LevelAmount.spawnspeed && PlayerHealth.movementenabled && !PauseMenu.pausemenuup && Movement.gamestarted){
            spawncoins();
            deploylasers();
          

        }
        cointimer += Time.deltaTime;
    }

    public  void deploylasers(){
        position = bound1;
        positiony = topbound;

        position += (float) random.NextDouble();
        positiony += (float) random.NextDouble();

        if(positiony >= topbound){
            positiony = topbound-0.1f;
        }
         if(position + 2 > Movement.playerx){
       Instantiate(toplaser, new Vector2(position + 2, positiony ),Quaternion.identity);
         }
               positiony += (float) random.NextDouble();

               if(position + 3 > Movement.playerx){
       Instantiate(toplaser, new Vector2(position + 3, positiony ),Quaternion.identity);
           }
        positiony -= (float) random.NextDouble();
        if(position + 4 > Movement.playerx){
        Instantiate(toplaser, new Vector2(position+4, positiony ),Quaternion.identity);
        }
          time = 0;
         
       
       
    }

    public void spawncoins(){
     
      position = bound1;
        positiony = topbound;
        position += (float) random.NextDouble();
        positiony += (float) random.NextDouble();
          if(positiony >= topbound){
            positiony = topbound-0.1f;
        }
       Instantiate(coin, new Vector2(position + 2, positiony ),Quaternion.identity);
          positiony += (float) random.NextDouble();
       Instantiate(coin, new Vector2(position + 3, positiony ),Quaternion.identity);         
        positiony -= (float) random.NextDouble();  
        Instantiate(coin, new Vector2(position+4, positiony ),Quaternion.identity);
          time = 0;
          
    }
}
