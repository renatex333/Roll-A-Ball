using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
        // transform.Translate(new Vector3(0, (float)Math.Sin(Time.time)/2, 0) * Time.deltaTime);
    }
}
