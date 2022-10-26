using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    // initialize an array of gameObject publicly so we can drag and drop the game objects into the array and randomly show them

    public GameObject[] gameObjects;
    List<int> answeredQuestions = new List<int>();
    public int previousQuestion;

    // function to show the game objects
    public void ShowGameObjects()
    {
        bool isAnswered = false;
        int randomIndex = Random.Range(0, gameObjects.Length);

        Debug.Log("Answered Questions: " + answeredQuestions.Count);

        if (answeredQuestions.Count > 0)
        {
            if (answeredQuestions.Count == gameObjects.Length)
            {
                Debug.Log("Done!");
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
                    answeredQuestions.Add(randomIndex);
                    gameObjects[previousQuestion].SetActive(false);
                    gameObjects[randomIndex].SetActive(true);
                    previousQuestion = randomIndex;
                    Debug.Log("1");
                }
                else
                {
                    Debug.Log("2");
                    ShowGameObjects();
                    return;
                }
            }
        }
        else
        {
            gameObjects[randomIndex].SetActive(true);
            answeredQuestions.Add(randomIndex);
            previousQuestion = randomIndex;
            Debug.Log("3");

        }
    }
}
