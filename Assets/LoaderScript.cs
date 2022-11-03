using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;

public class LoaderScript : MonoBehaviour
{

    // Get a serialized reference to the main menu
    [SerializeField] private GameObject mainMenu;
    public GameObject loaderBar;
    public float time = 1.3f;
    GameObject levels;

    private void Start()
    {
        transform.localScale = Vector2.zero;
    }

    public void Open()
    {
        transform.LeanScale(Vector2.one * 3, 0.1f).setEaseInCubic();
        // Reset levels object to default position

        LeanTween.delayedCall(1.3f, () =>
        {
            transform.LeanScale(Vector2.zero, 0.1f).setEaseInCubic();
            mainMenu.GetComponent<MainMenu>().Open();
        });

        // Start the loader bar animation
        LeanTween.scaleX(loaderBar, 0.33f, 1f).setEaseInOutCirc().setOnComplete(() =>
        {
            LeanTween.scaleX(loaderBar, 0f, 1f).setEaseInOutCirc();
        });
    }
}
