using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void GUide()
    {
        SceneManager.LoadScene("Guide");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
