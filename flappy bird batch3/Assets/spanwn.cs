﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spanwn : MonoBehaviour
{

    float time = 0;
    float timer = 1;
    public GameObject pipe;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(time<=0){
            Instantiate(pipe, transform.position, Quaternion.identity);
            time=timer;
        }
        else{
            time -= Time.deltaTime;
        }
    }
}
