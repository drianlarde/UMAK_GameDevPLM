using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("Play Game");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }

    public void Open()
    {
        transform.LeanScale(Vector2.one, 0.1f).setEaseInCubic();
    }

    public void Close()
    {
        transform.LeanScale(Vector2.zero, 0.1f).setEaseInCubic();
    }
}
