using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManagerScript : MonoBehaviour
{

    public GameObject[] gameObjects;
    public GameObject doneGameObject;
    List<int> answeredQuestions = new List<int>();
    public int previousQuestion;
    public GameObject TimerBar;

    public GameObject[] WebsiteUIObject;

    public void ShowGameObjects()
    {
        // get TimerBar script and start the timer by invoking the function startTimer()
        TimerBar.GetComponent<TimerBarScript>().resetTimer();
        TimerBar.GetComponent<TimerBarScript>().startTimer();

        bool isAnswered = false;
        int randomIndex = Random.Range(0, gameObjects.Length);

        // Debug.Log("Answered Questions: " + answeredQuestions.Count);

        if (answeredQuestions.Count > 0)
        {
            if (answeredQuestions.Count == gameObjects.Length)
            {
                // Debug.Log("Done!");

                foreach (GameObject gameObject in gameObjects)
                {
                    gameObject.SetActive(false);
                    gameObject.GetComponent<LevelsScript>().Reset();
                }

                TimerBar.GetComponent<TimerBarScript>().clearTimer();
                answeredQuestions.Clear();
                doneGameObject.GetComponent<DoneScript>().Open();

                return;
            }
            else
            {
                for (int i = 0; i < answeredQuestions.Count; i++)
                {
                    if (answeredQuestions[i] == randomIndex)
                    {
                        isAnswered = true;
                        break;
                    }
                }
                if (!isAnswered)
                {
                    // Debug.Log("1");
                    answeredQuestions.Add(randomIndex);
                    gameObjects[previousQuestion].GetComponent<LevelsScript>().Close();
                    previousQuestion = randomIndex;

                    // gameObjects[randomIndex].transform.Find("LikeButton").gameObject.SetActive(true);
                    // gameObjects[randomIndex].transform.Find("ReportButton").gameObject.SetActive(true);
                    gameObjects[randomIndex].transform.Find("WrongButton").gameObject.SetActive(true);
                    gameObjects[randomIndex].transform.Find("RightButton").gameObject.SetActive(true);
                    gameObjects[randomIndex].SetActive(true);

                    gameObjects[randomIndex].GetComponent<LevelsScript>().Open();
                }
                else
                {
                    // Debug.Log("2");
                    ShowGameObjects();
                    return;
                }
            }
        }
        else
        {
            // Debug.Log("3");
            // gameObjects[randomIndex].transform.Find("LikeButton").gameObject.SetActive(true);
            // gameObjects[randomIndex].transform.Find("ReportButton").gameObject.SetActive(true);
            gameObjects[randomIndex].transform.Find("WrongButton").gameObject.SetActive(true);
            gameObjects[randomIndex].transform.Find("RightButton").gameObject.SetActive(true);
            gameObjects[randomIndex].SetActive(true);
            gameObjects[randomIndex].GetComponent<LevelsScript>().Open();
            answeredQuestions.Add(randomIndex);
            previousQuestion = randomIndex;
        }
    }

    public void ResetGame()
    {
        Debug.Log("Reset Game");
        foreach (GameObject gameObject in gameObjects)
        {
            gameObject.SetActive(false);
            gameObject.GetComponent<LevelsScript>().Reset();
        }

        answeredQuestions.Clear();
        gameObjects[previousQuestion].SetActive(false);
        TimerBar.GetComponent<TimerBarScript>().clearTimer();

        // Disable the website UI
        foreach (GameObject gameObject in WebsiteUIObject)
        {
            // Get their script and invoke the function Close()
            gameObject.GetComponent<WebsiteUIScript>().Close();
        }
    }
}
