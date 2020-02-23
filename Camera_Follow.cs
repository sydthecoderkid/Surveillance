using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
    public float positionx;
    public GameObject player;
 
    public static float thisx;
    private float thisy;

    private float thisz;
    // Start is called before the first frame update
    void Start()
    {
        thisx = transform.position.x;
        thisy = transform.position.y;
        thisz = transform.position.z;
        transform.position = new Vector3(thisx, thisy, thisz);
    }

    // Update is called once per frame
    void Update()
    {
        
         transform.position = new Vector3(thisx, thisy, thisz);
          if(Movement.gamestarted && PlayerHealth.movementenabled){
         thisx += (Tempmove.movespeed * Time.deltaTime);
          }
        
    }
}