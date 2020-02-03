using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Random;


public class SpawnLasers : MonoBehaviour
{
    public GameObject wall1;
    public GameObject wall2;
    public GameObject laserholder;
        public GameObject toplaser;
            public GameObject bottomlaser;

    public float position;

    private float time;

    public static System.Random random;

    private int numlasers;
    
    // Start is called before the first frame update
    void Start()
    {
     random = new System.Random();   
     
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(OnRender.lasersdestroyed && time >= 3f){

            deploylasers();
          

        }
    }

    public  void deploylasers(){
        int bound1 = (int) wall1.transform.position.x + 2;
        int bound2 =(int) wall2.transform.position.x;
        int picklaser = random.Next(0, 2);
        position =  (float) random.Next(bound1, bound2) + 1.4f;
       Instantiate(laserholder, new Vector2(position, -0.3026911f ),Quaternion.identity);
         position += 5;
        Instantiate(laserholder, new Vector2(position, -0.3026911f ),Quaternion.identity);
                 time = 0;
         
       
       
    }
}
