using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySounds : MonoBehaviour
{
        public AudioSource lazersound;
      public AudioSource coinsound;
   
         
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(LazerHit.playlazersound){
          lazersound.Play();
            LazerHit.playlazersound = false;
       }
        if(LazerHit.playcoinsound){
           coinsound.Play();
            LazerHit.playcoinsound = false;
       }
    }

   
  
}
