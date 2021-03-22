using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadscene : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "sphere")
        {
            SceneManager.LoadScene("Level-2");//loading a new scene
        }
        if(collision.gameObject.tag =="sphere1")
        {
            SceneManager.LoadScene("Level-3");//loading a new scene
        }
        if (collision.gameObject.tag == "sphere2")
        {
            SceneManager.LoadScene("End");//loading a new scene
        }
    }
}

