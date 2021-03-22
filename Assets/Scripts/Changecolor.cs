using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changecolor : MonoBehaviour
{

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")//checking collision using tag
        {

            GetComponent<MeshRenderer>().material.color = Color.cyan;//getting color from meshrenderer

        }

    }
}
