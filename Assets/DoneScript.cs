using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoneScript : MonoBehaviour
{
    public AudioSource winSfx;

    private void Start()
    {
        transform.localScale = Vector2.zero;
        transform.LeanMoveLocal(new Vector2(0, -5000), 0.1f).setEaseInOutCubic();
    }
    public void Open()
    {
        transform.LeanScale(Vector2.one * 3, 0.1f).setEaseInCubic();
        transform.LeanMoveLocal(new Vector2(0, 0), 0.3f).setEaseInOutCubic();
        winSfx.Play();
    }

    public void Close()
    {

        transform.LeanMoveLocal(new Vector2(0, 5000), 0.1f).setEaseInOutCubic();
    }

    public void Reset()
    {
        transform.LeanScale(Vector2.zero, 0.1f).setEaseInCubic();
        transform.LeanMoveLocal(new Vector2(0, -10000), 1.6f).setEaseInOutCubic();
    }
}
