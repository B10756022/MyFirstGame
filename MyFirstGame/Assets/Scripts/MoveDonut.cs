﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDonut : MonoBehaviour
{
   public float speed = 40;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*飛天甜甜圈*/
        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }
}
