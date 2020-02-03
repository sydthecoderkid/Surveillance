using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnRender : MonoBehaviour
{
    // Start is called before the first frame update
    public Renderer render;
    public GameObject holder;

    public static bool lasersdestroyed;

    private float time;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if(time >= 2 && render.isVisible == false){
            lasersdestroyed = true;
            Destroy(holder);
        }
    }
}
