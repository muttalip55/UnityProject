using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Numbers1 : MonoBehaviour
{
    private GameObject appleObject;
    private Vector3 applePos;
    private bool isDrag = false;

    void Start()
    {

    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(touch.position), Vector2.zero);
                if (hit.collider != null && hit.collider.tag == "apple")
                {

                    isDrag = true;
                    appleObject = hit.collider.gameObject;
                    appleObject.GetComponent<Rigidbody2D>().gravityScale = 0.8f;
                    applePos = appleObject.transform.position;
                }
            }

            if (touch.phase == TouchPhase.Moved)
            {
                if (isDrag)
                {
                    applePos = Camera.main.ScreenToWorldPoint(touch.position);
                    applePos.z = 0;
                }
            }

            if (touch.phase == TouchPhase.Ended)
            {
                isDrag = false;
            }
        }

        if (isDrag)
        {
            appleObject.transform.position = applePos;
        }
    }
}
