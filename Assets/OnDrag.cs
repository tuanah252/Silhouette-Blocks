using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDrag : MonoBehaviour
{

    public float limit = 2.6f;
    // Start is called before the first frame update
    private bool check;
    Vector3 offset;
    private object collision;

    void OnMouseDown()
    {
        check = true;
    }
    void OnMouseDrag()
    {
        if (check)
        {

            float distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
            transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen));


        }

    }
    void Update()
    {
        if (transform.position.y < limit)
        {
            transform.position = new Vector3(0.1f, limit + 5, -3.58f);
        }
    }

}


