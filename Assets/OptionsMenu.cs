using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenu : MonoBehaviour
{
    // Animates the options menu when enabled

    private void Start()
    {
        transform.localScale = Vector2.zero;
    }

    public void Open()
    {
        transform.LeanScale(Vector2.one * 3, 0.1f).setEaseInCubic();
    }

    public void Close()
    {
        transform.LeanScale(Vector2.zero, 0.1f).setEaseInCubic();
    }
}
