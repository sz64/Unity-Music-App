using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Drum ()
    {
        SceneManager.LoadScene("Drum");
    }
    public void Piano ()
    {
        SceneManager.LoadScene("Piano");
    }
    public void Quit ()
    {
        Application.Quit();
    }
    public void Back ()
    {
        SceneManager.LoadScene("Main");
    }
}
