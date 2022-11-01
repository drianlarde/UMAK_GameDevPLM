using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebsiteUIScript : MonoBehaviour
{
    Vector2 difference = Vector2.zero;
    public GameObject dimBGObject;

    void Awake()
    {
        transform.localScale = Vector2.zero;
    }

    public void Open()
    {
        dimBGObject.GetComponent<DimBGScript>().Open();
        transform.LeanScale(Vector2.one * 24, 0.1f).setEaseInCubic();
    }

    public void Close()
    {
        dimBGObject.GetComponent<DimBGScript>().Close();
        transform.LeanScale(Vector2.zero, 0.1f).setEaseInCubic();
    }

    private void OnMouseDown()
    {
        difference = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)transform.position;
    }

    private void OnMouseDrag()
    {
        transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - difference;
    }

    void Update()
    {
        if (transform.position.x > 5f || transform.position.x < -5f || transform.position.y > 10f || transform.position.y < -10.0f)
        {
            transform.LeanMove(new Vector2(0, 0), 0.5f).setEaseOutCubic();
        }

        if (Input.GetMouseButtonDown(0))
        {

            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

            if (hit.collider == null)

            {
                Close();
            }
        }
    }



}
