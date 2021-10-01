using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shopping : MonoBehaviour
{

    public GameObject openShoppingList;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }

    public void ShoppingList()
    {
        openShoppingList.SetActive(true);
        Time.timeScale = 0;
    }

    public void CloseList()
    {
        openShoppingList.SetActive(false);
        Time.timeScale = 1;
    }
}
