using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutfitAnimation : MonoBehaviour
{
    public Animator anim;
     public string animname;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playanim();
        if(Outfits.baseoutfit){
           animname = "BunnyIdle";
        }
          if(Outfits.outfitone){
          animname = "BunnyOutfit1Idle";
        }
           if(Outfits.outfittwo){
          animname = "BunnyOutfit2Idle";
        }
    }
public void playanim(){
        anim.Play(animname);
    }
}
