using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Numbers3 : MonoBehaviour
{
    private GameObject eggObject;
    public GameObject ChickenSound;
    private Vector3 eggPos;
    private bool isDrag = false;

    void Start()
    {
        
    }
    void Update()
    {

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            ChickenSound.SetActive(true);
            if (touch.phase == TouchPhase.Began)
            {
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(touch.position), Vector2.zero);
                if (hit.collider != null && hit.collider.tag == "egg")
                {
                    ChickenSound.SetActive(true);
                    isDrag = true;
                    eggObject = hit.collider.gameObject;
                 //   eggObject.GetComponent<Rigidbody2D>().gravityScale = 0.8f;
                    eggPos = eggObject.transform.position;
                }

            }

            if (touch.phase == TouchPhase.Moved)
            {
                if (isDrag)
                {
                    eggPos = Camera.main.ScreenToWorldPoint(touch.position);
                    eggPos.z = 0;
                }
            }

            if (touch.phase == TouchPhase.Ended)
            {
                isDrag = false;
            }
        }

        if (isDrag)
        {
            eggObject.transform.position = eggPos;
        }
        ChickenSound.SetActive(false);
    }


}
