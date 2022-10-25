using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoaderScript : MonoBehaviour
{

    // Get a serialized reference to the main menu
    [SerializeField] private GameObject mainMenu;

    private void Start()
    {
        transform.localScale = Vector2.zero;
    }

    public void Open()
    {
        transform.LeanScale(Vector2.one, 0.1f).setEaseInCubic();
        LeanTween.delayedCall(1.3f, () =>
        {
            transform.LeanScale(Vector2.zero, 0.1f).setEaseInCubic();
            mainMenu.GetComponent<MainMenu>().Open();
        });
    }
}
