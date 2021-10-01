using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal1Manager : MonoBehaviour
{
    public GameObject dog, dogBlack, monkey, monkeyBlack, donkey, donkeyBlack;
    private Vector2 dogPos, donkeyPos, monkeyPos;

    int animal2Star = 0;
    public GameObject star1, star2, star3;

    public AudioSource source;
    public AudioClip[] correct;
    public AudioClip incorrect;
    void Start()
    {
        dogPos = dog.transform.position;
        donkeyPos = donkey.transform.position;
        monkeyPos = monkey.transform.position;
       // PlayerPrefs.SetInt("animal2Star", 0);
        animal2Star = PlayerPrefs.GetInt("animal2Star");
        starGet(animal2Star);
    }

    public void DragDog()
    { 
        if(dog.transform.position != dogBlack.transform.position)
            dog.transform.position = Input.mousePosition;
    }

    public void DropDog()
    {
        float Distance = Vector3.Distance(dog.transform.position, dogBlack.transform.position);
        if (Distance < 50)
        {
            source.clip = correct[0];
            source.Play();
            dog.transform.position = dogBlack.transform.position;

            animal2Star = PlayerPrefs.GetInt("animal2Star");
            if (animal2Star < 3) { 
                PlayerPrefs.SetInt("animal1Star", animal2Star + 1);
            starGet(animal2Star + 1);
            }
        }
        else
        {
            dog.transform.position = dogPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    public void DragDonkey()
    {
        if (donkey.transform.position != donkeyBlack.transform.position)
            donkey.transform.position = Input.mousePosition;
    }

    public void DropDonkey()
    {
        float Distance = Vector3.Distance(donkey.transform.position, donkeyBlack.transform.position);

        if (Distance < 50)
        {
            source.clip = correct[1];
            source.Play();
            donkey.transform.position = donkeyBlack.transform.position;

            animal2Star = PlayerPrefs.GetInt("animal2Star");
            if (animal2Star < 3) { 
                PlayerPrefs.SetInt("animal2Star", animal2Star + 1);
            starGet(animal2Star + 1);
            }
        }
        else
        {
            donkey.transform.position = donkeyPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    public void DragMonkey()
    {
        if (monkey.transform.position != monkeyBlack.transform.position)
            monkey.transform.position = Input.mousePosition;
    }

    public void DropMonkey()
    {
        float Distance = Vector3.Distance(monkey.transform.position, monkeyBlack.transform.position);

        if (Distance < 50)
        {
            source.clip = correct[2];
            source.Play();
            monkey.transform.position = monkeyBlack.transform.position;

            animal2Star = PlayerPrefs.GetInt("animal2Star");
            if(animal2Star < 3) { 
            PlayerPrefs.SetInt("animal2Star", animal2Star + 1);
            starGet(animal2Star + 1);
            }
        }
        else
        {
            monkey.transform.position = monkeyPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    void starGet(int animal1Star)
    {
        Debug.Log("animal1Star: " + animal1Star);
        if (animal1Star == 3)
        {
            PlayerPrefs.SetInt("animal2Star", 3);
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);

        }
        else if (animal1Star == 2)
        {
            star1.SetActive(true);
            star2.SetActive(true);
        }
        else if (animal1Star == 1)
        {
            star1.SetActive(true);
        }
    }
}
