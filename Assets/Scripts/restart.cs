using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restart : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            Application.LoadLevel("Level-1");//loading current level
        }
        if (Input.GetKey(KeyCode.E))
        {
            Application.LoadLevel("Level-2");//loading current level
        }
        if (Input.GetKey(KeyCode.Q))
        {
            Application.LoadLevel("Level-3");//loading current level
        }
    }
    
}
