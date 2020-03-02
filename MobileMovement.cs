using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileMovement : MonoBehaviour
{

   public static Vector3 fingerpress;

   private static float lastpress;

  public Camera thiscamera;

  private int index;

  public Vector2 thisvector;

   

   // public Touch touch;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
      
       if(Input.touches.Length > 0)
     {
         Touch touch = Input.touches[0];
           thisvector = thiscamera.ScreenToWorldPoint(new Vector3(Input.touches[0].position.x, Input.touches[0].position.y, thiscamera.nearClipPlane));
         if(Movement.player.transform.position.y < thisvector.y && touch.phase == TouchPhase.Moved){
             if(!OutofBounds.topwall){
                Movement.move_up();
             }
            }
             if(Movement.player.transform.position.y > thisvector.y && touch.phase == TouchPhase.Moved){
                 if(!OutofBounds.bottomwall){
                Movement.move_down();
                 }
            }
             
         if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled)
         {
             if(!OutofBounds.leftwall)
             {
               if(Movement.player.transform.position.x > thisvector.x && touch.phase == TouchPhase.Moved){
               // Movement.move_left();
            }
                if(!OutofBounds.rightwall){
                if(Movement.player.transform.position.x > thisvector.x && touch.phase == TouchPhase.Moved){
               // Movement.move_right();
            }
          }
          }
         }
     }
  }
}
