using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBounce : MonoBehaviour
{
    private float positionx;
    private float originalpositiony;

    private float positiony;

  
    // Start is called before the first frame update
    void Start()
    {
        positiony = this.gameObject.transform.position.y;
          positionx = this.gameObject.transform.position.x;
          originalpositiony = this.gameObject.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        positiony += this.gameObject.transform.position.y;

        if(this.gameObject.transform.position.y > 1.0f){
            while(this.gameObject.transform.position.y > originalpositiony){
            this.gameObject.transform.position = new Vector2(positionx, (positiony - 0.2f));
            }
        }
         if(this.gameObject.transform.position.y < 1.0f){
            this.gameObject.transform.position = new Vector2(positionx, (positiony + 0.2f));
            Debug.Log("running");
        }
    }
}
