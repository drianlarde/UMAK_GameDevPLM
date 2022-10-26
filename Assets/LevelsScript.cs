using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsScript : MonoBehaviour
{

    // private void Start()
    // {
    //     transform.localScale = Vector2.zero;
    //     transform.LeanMoveLocal(new Vector2(0, -1000), 0.3f).setEaseInOutCubic();
    // }
    public void Open()
    {

        transform.LeanScale(Vector2.one, 0.1f).setEaseInCubic();
        transform.LeanMoveLocal(new Vector2(0, 0), 0.3f).setEaseInOutCubic();
    }

    public void Close()
    {
        transform.LeanMoveLocal(new Vector2(0, 1000), 0.3f).setEaseInOutCubic();
    }

    public void Reset()
    {
        transform.LeanScale(Vector2.zero, 0.1f).setEaseInCubic();
        transform.LeanMoveLocal(new Vector2(0, -2000), 1.6f).setEaseInOutCubic();
    }
}
