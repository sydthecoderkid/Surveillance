using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecollider : MonoBehaviour
{
    public BoxCollider2D lazercol;

    public GameObject lazerholder;
    public bool goingup = true;
    public bool goingdown = false;

    public float positionx; 

    public float positiony;

    private float time;

    private float origY;
    // Start is called before the first frame update
    void Start()
    {
        positionx = lazerholder.transform.position.x;
        positiony = lazerholder.transform.position.y;
        origY = lazerholder.transform.position.y;
        time = 0.6f;
      
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerHealth.movementenabled){
        lazerholder.transform.position = new Vector2(lazerholder.transform.position.x, positiony);

        if(time >= 0.6f && goingup){
            positiony += 0.4f;
        goingup = false;
        goingdown = true;
        time = 0;
        }
        if(time >= 0.6f && goingdown){
            positiony = origY;
        goingup = true;
        goingdown = false;
        time = 0;
        }
        }
        
    }
    void FixedUpdate(){
        
        time += Time.deltaTime;
    }
}
