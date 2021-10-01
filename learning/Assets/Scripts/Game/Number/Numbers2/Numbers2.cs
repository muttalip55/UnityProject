using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Numbers2 : MonoBehaviour
{
    private GameObject fishObject;
    private Vector3 fishPos;
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
                if (hit.collider != null && hit.collider.CompareTag("fish"))
                {
                    isDrag = true;
                    fishObject = hit.collider.gameObject;
                    fishPos = fishObject.transform.position;
                }
            }

            if (touch.phase == TouchPhase.Moved)
            {
                if (isDrag)
                {
                    fishPos = Camera.main.ScreenToWorldPoint(touch.position);
                    fishPos.z = 0;
                }
            }

            if (touch.phase == TouchPhase.Ended)
            {
                isDrag = false;
            }
        }

        if (isDrag)
        {
            fishObject.transform.position = fishPos;
        }
    }


}
