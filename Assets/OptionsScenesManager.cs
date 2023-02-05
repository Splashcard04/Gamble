using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsScenesManager : MonoBehaviour
{
    public void loadMainGamble()
    {
        SceneManager.LoadScene(1);
    }

    public void loadStartMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void loadOptionsMenu()
    {
        SceneManager.LoadScene(2);
    }

    public void quit()
    {
        Application.Quit();
    }
}
