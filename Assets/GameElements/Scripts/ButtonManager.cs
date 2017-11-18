using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{

    public void OpenSceneButton(string openScene)
    {
        SceneManager.LoadScene(openScene);
    }

    public void ExitGameButton()
    {
        Application.Quit();
    }

}

