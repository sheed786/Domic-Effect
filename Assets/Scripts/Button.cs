using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//using for loading different Scenes

public class Button : MonoBehaviour
{
    public  void Play()
    {
        SceneManager.LoadScene("LEVEL-1");//Loading a Scene
    }
    public void Gameplay()
    {
        SceneManager.LoadScene("Gameplay");//Loading a Scene
    }
    public void Back()
    {
        SceneManager.LoadScene("Main");//Loading a Scene
    }
    public void Restart()
    {
        SceneManager.LoadScene("Main");//Loading a Scene
    }
    public void Quit()
    {
        Application.Quit();//Loading a Scene
    }
}
