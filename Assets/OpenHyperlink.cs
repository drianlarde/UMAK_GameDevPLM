using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
[RequireComponent(typeof(TMP_Text))]

public class OpenHyperlink : MonoBehaviour
{
    public string url;

    public void OnMouseDown()
    {
        Debug.Log("Open Link");

        Application.OpenURL(url);
    }
}
