using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTheMouse : MonoBehaviour
{
    void Update()
    {
        //Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //transform.position = mousePos;
        transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
