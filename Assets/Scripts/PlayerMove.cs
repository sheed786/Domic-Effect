using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
   
    float movespeed = 2f;//declaring variables

    
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))//input value
        {
            transform.Translate(Vector3.forward * movespeed * Time.deltaTime);//moving front

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * movespeed * Time.deltaTime);//moving back
        }
        
        
    }
    
}
