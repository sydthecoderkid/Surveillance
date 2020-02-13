using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayEffect : MonoBehaviour
{
        public ParticleSystem particleplayer;
        public AudioSource playsound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( PlayerHealth.player != null){
        this.gameObject.transform.position = PlayerHealth.player.transform.position;
        }
        if(PlayerHealth.playerdied){
            particleplayer.Play();
            playsound.Play();
            PlayerHealth.playerdied = false;
        }
    }
}
