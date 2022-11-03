using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ClickCloseScript : MonoBehaviour
{


    // If this button gameobject is clicked then close this gameobject
    public void OnMouseDown()
    {
        // transform.parent.gameObject.SetActive(false);
        // Get the sibling button gameobject that has a name of "LikeButton" and set it to false active
        transform.parent.Find("RightButton").gameObject.SetActive(false);
        transform.parent.Find("WrongButton").gameObject.SetActive(false);
        Debug.Log("Clicked Close Button");
    }
}
