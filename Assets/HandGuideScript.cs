using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGuideScript : MonoBehaviour
{

    private bool isGuideOn = true;

    void Start()
    {
        // Set alpha to zero
        gameObject.LeanAlpha(0f, 0f);
    }

    public void Open()
    {
        gameObject.LeanAlpha(1f, 0.3f).setEaseInCubic();
        transform.LeanMoveLocal(new Vector2(260, 500), 1f).setEaseInOutCubic().setOnComplete(() =>
        {
            gameObject.LeanAlpha(0f, 0.3f).setEaseInCubic().setOnComplete(() =>
            {
                transform.LeanMoveLocal(new Vector2(260, -500), 0.1f).setEaseInOutCubic().setOnComplete(() =>
                {
                    if (isGuideOn)
                    {
                        Open();
                    }
                    return;
                });
            });
        });
    }

    public void Close()
    {
        isGuideOn = false;
        gameObject.LeanAlpha(0f, 0.3f).setEaseInCubic();
        transform.LeanMoveLocal(new Vector2(260, -500), 0.1f).setEaseInOutCubic();
    }
}
