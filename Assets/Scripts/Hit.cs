using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
  float movespeed = 10f;//giving movementspeed
    private void OnMouseDown()
    {
            transform.Translate(Vector3.right * movespeed * Time.deltaTime);//moving position to right
    }
}











