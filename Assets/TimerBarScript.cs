using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;

public class TimerBarScript : MonoBehaviour
{
    public GameObject tryAgainObject;
    public GameObject gameManagerObject;
    public int time = 5;

    public void startTimer()
    {
        // Enable the timer bar
        gameObject.SetActive(true);
        LeanTween.scaleX(this.gameObject, 0, time).setOnComplete(() =>
        {
            tryAgainObject.GetComponent<DoneScript>().Open();
            gameManagerObject.GetComponent<GameManagerScript>().ResetGame();

        });
    }

    public void resetTimer()
    {
        LeanTween.cancel(this.gameObject);
        LeanTween.scaleX(this.gameObject, 1, 0);
    }

    public void clearTimer()
    {
        LeanTween.cancel(this.gameObject);
        LeanTween.scaleX(this.gameObject, 0, 0);
        gameObject.SetActive(false);
    }

}
