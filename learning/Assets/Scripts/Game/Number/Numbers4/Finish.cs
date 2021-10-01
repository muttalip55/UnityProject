using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    private int animal3Star;
    public GameObject bait1,bait2,bait3;
    public GameObject star1, star2, star3,board;

    void Update()
    {
        animal3Star = PlayerPrefs.GetInt("animal3Star");
        starGet(animal3Star);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(animal3Star);
       if( other.tag == "mauseAnimal3")
       {
            bait1.SetActive(false);
            bait2.SetActive(true);
            bait3.SetActive(false);
            PlayerPrefs.SetInt("animal3Star", 1);
        }

         if (other.tag == "dogAnimal3")
         {
            bait1.SetActive(false);
            bait2.SetActive(false);
            bait3.SetActive(true);
            PlayerPrefs.SetInt("animal3Star", 2);
        }

        if (other.tag == "rabbitAnimal3")
        {
            bait1.SetActive(false);
            bait2.SetActive(false);
            bait3.SetActive(false);
            PlayerPrefs.SetInt("animal3Star", 3);
        }
        
    }


    private void starGet(int animal3Star)
    {
        if (animal3Star == 3)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
            board.SetActive(true);
            bait3.SetActive(false);
            bait2.SetActive(false);
            bait1.SetActive(false);

        }
        else if (animal3Star == 2)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            bait3.SetActive(true);
            bait2.SetActive(false);
            bait1.SetActive(false);
        }
        else if (animal3Star == 1)
        {
            star1.SetActive(true);
            bait3.SetActive(false);
            bait2.SetActive(true);
            bait1.SetActive(false);
        }
    }
}
