using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollGuideScript : MonoBehaviour
{
    void Start()
    {
        gameObject.LeanAlpha(0f, 0f);
    }

    public void Open()
    {
        gameObject.LeanAlpha(1f, 0.3f).setEaseInCubic();
    }

    public void Close()
    {
        gameObject.LeanAlpha(0f, 0.3f).setEaseInCubic();
    }
}
