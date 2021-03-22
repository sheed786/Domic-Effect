using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitleft : MonoBehaviour
{
    float movespeed = 10f;

    private void OnMouseDown()
    {
       transform.Translate(Vector3.left * movespeed * Time.deltaTime);//moving position to left
    }
}

