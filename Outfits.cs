﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Outfits : MonoBehaviour
{
    public static bool baseoutfit;

    public static bool outfitone;

    public static bool outfittwo;

    
    // Start is called before the first frame update
    void Start()
    {
        if(!outfitone && !outfittwo){
            baseoutfit = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
