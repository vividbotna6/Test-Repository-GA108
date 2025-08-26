using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_01 : MonoBehaviour
{
    public float rotationspeed = 30f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationspeed * Time.deltaTime, 0);
    }
}
