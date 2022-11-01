using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject scoreObject;

    public void PlayGame()
    {
        // Debug.Log("Play Game");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        // Debug.Log("Quit Game");
        Application.Quit();
    }

    public void Open()
    {
        transform.LeanScale(Vector2.one * 3, 0.1f).setEaseInCubic();
        scoreObject.GetComponent<ScoreScript>().showHighScore();
    }

    public void Close()
    {
        transform.LeanScale(Vector2.zero, 0.1f).setEaseInCubic();
        scoreObject.GetComponent<ScoreScript>().hideHighScore();
    }
}
