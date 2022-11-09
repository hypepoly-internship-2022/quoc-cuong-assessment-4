using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerVision : MonoBehaviour
{

    public float speedH = 2f;
    public float speedV = 2f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Mathf.Abs(yaw) < 40){
            yaw += speedH * Input.GetAxis("Mouse X");
            pitch -= speedV * Input.GetAxis("Mouse Y");
        }
        else{
            if(yaw < 0){
                yaw = -39.99999f;
            } else {
                yaw = 39.99999f;
            }
        }

        
        // transform.eulerAngles = new Vector3(0.0f, yaw, 0.0f); //can change x = pitch to move cam vision up down
    }
}
