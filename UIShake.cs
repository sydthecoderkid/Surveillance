using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIShake : MonoBehaviour
{
    public float originalposx;

     public static float timer;
    private static GameObject thisobject;

    private static bool shook;

   
    // Start is called before the first frame update
    void Start()
    {
     thisobject = this.gameObject;   
     originalposx = thisobject.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
       if(thisobject.transform.position.x >= (originalposx + 0.2f) && timer >= 0.15f && shook){
        thisobject.transform.position = new Vector2((thisobject.transform.position.x-0.2f), thisobject.transform.position.y);
        shook = false;
       }
       if(!shook && thisobject.transform.position.x > originalposx || !shook && thisobject.transform.position.x < originalposx){
           thisobject.transform.position = new Vector2((thisobject.transform.position.x), thisobject.transform.position.y);
       }
    }

    public static void shakeUI(){
        timer = 0;
        thisobject.transform.position = new Vector2((thisobject.transform.position.x+0.2f), thisobject.transform.position.y);
         shook = true;
        
    }
}
