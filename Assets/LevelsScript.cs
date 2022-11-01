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
        // Debug.Log("'Ran!'");
        transform.LeanScale(Vector2.one * 3, 0.1f).setEaseInCubic();
        transform.LeanMoveLocal(new Vector2(0, 0), 0.3f).setEaseInOutCubic();
    }

    public void Close()
    {
        transform.LeanMoveLocal(new Vector2(0, 10000), 0.3f).setEaseInOutCubic();
    }

    public void Reset()
    {
        // Debug.Log("Reset Level Positions!");
        transform.LeanScale(Vector2.zero, 0.1f).setEaseInCubic();
        transform.LeanMoveLocal(new Vector2(0, -5000), 1.6f).setEaseInOutCubic();
    }
}
