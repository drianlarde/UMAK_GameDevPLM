using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

public class TimerBarScript : MonoBehaviour
{
    public GameObject tryAgainObject;
    public GameObject gameManagerObject;
    public GameObject cameraObject;
    public int time = 10;
    public PostProcessVolume volume;
    public Image image;
    private Vignette _Vignette;
    private ChromaticAberration _ChromaticAberration;

    private void Start()
    {
        image = GetComponent<Image>();
        var tempColor = image.color;
        tempColor.a = 0f;
        image.color = tempColor;
        volume.profile.TryGetSettings(out _Vignette);
        volume.profile.TryGetSettings(out _ChromaticAberration);
    }

    public void startTimer()
    {
        // Enable the timer bar
        var tempColor = image.color;
        tempColor.a = 1f;
        image.color = tempColor;
        LeanTween.scaleX(this.gameObject, 0, time).setOnComplete(() =>
        {
            tryAgainObject.GetComponent<DoneScript>().Open();
            gameManagerObject.GetComponent<GameManagerScript>().ResetGame();

        });

        // Start the vignette effect starting from 0.25 intensity to 0.5 intensity with a duration of 10 seconds
        _Vignette.intensity.value = 0.25f;
        _ChromaticAberration.intensity.value = 0.2f;
        LeanTween.value(gameObject, 0.25f, 0.5f, time).setOnUpdate((float val) =>
        {
            _Vignette.intensity.value = val;
        });
        LeanTween.value(gameObject, 0.2f, 1f, time).setOnUpdate((float val) =>
        {
            _ChromaticAberration.intensity.value = val;
        });
    }

    public void resetTimer()
    {
        var tempColor = image.color;
        tempColor.a = 0f;
        image.color = tempColor;
        LeanTween.cancel(this.gameObject);
        LeanTween.scaleX(this.gameObject, 1, 0);
        _Vignette.intensity.value = 0.25f;
        _ChromaticAberration.intensity.value = 0.2f;
    }

    public void clearTimer()
    {
        var tempColor = image.color;
        tempColor.a = 0f;
        image.color = tempColor;
        LeanTween.cancel(this.gameObject);
        LeanTween.scaleX(this.gameObject, 0, 0);
        _Vignette.intensity.value = 0.25f;
        _ChromaticAberration.intensity.value = 0.2f;
    }

}
