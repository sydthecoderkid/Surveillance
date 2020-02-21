using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileMovement : MonoBehaviour
{

   public static Vector3 thisvector;

  public Camera thiscamera;

   

   // public Touch touch;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        foreach(Touch touch in Input.touches){
            if(!Movement.gamestarted){
                Movement.startgame();
            }
            Movement.moveright();
            thisvector = thiscamera.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, thiscamera.nearClipPlane));
            if(Movement.player.transform.position.y < thisvector.y && touch.phase == TouchPhase.Moved){
                Movement.moveup();
            }
            if(Movement.player.transform.position.y > thisvector.y&& touch.phase == TouchPhase.Moved){
                Movement.movedown();
            }
         }
  }
}
