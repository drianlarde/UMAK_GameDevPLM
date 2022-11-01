using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DimBGScript : MonoBehaviour
{

    Vector2 scaleOpen = new Vector2(1500, 1500);

    void Start()
    {
        gameObject.LeanAlpha(0f, 0.1f).setEaseInCubic();
    }

    public void Open()
    {
        gameObject.LeanScale(scaleOpen, 0.1f).setEaseInCubic();
        gameObject.LeanAlpha(0.5f, 0.1f).setEaseInCubic();
    }

    public void Close()
    {
        gameObject.LeanScale(Vector2.zero, 0.1f).setEaseInCubic();
        gameObject.LeanAlpha(0f, 0.1f).setEaseInCubic();
    }
}
