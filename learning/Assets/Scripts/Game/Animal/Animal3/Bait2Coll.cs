using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bait2Coll : MonoBehaviour
{
    public GameObject door, finish;


    private void OnTriggerEnter2D(Collider2D other)
    {
        door.SetActive(false);
        finish.SetActive(true);
    }
}
