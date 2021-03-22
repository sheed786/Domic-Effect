using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour
{

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "wall")//checking collision using tag
        {

            GetComponent<MeshRenderer>().material.color = Color.cyan;//getting color from meshrenderer

        }

    }
}
