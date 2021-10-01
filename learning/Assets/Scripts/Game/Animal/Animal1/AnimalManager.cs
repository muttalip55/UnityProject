using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalManager : MonoBehaviour
{
    public GameObject chicken, chickenBlack, elephant, elephantBlack, lion, lionBlack;
    private Vector2 chickenPos, elephantPos, lionPos;

    int animal1Star;
    public GameObject star1, star2, star3;

    public AudioSource source;
    public AudioClip[] correct;
    public AudioClip incorrect;
    void Start()
    {
        chickenPos = chicken.transform.position;
        elephantPos = elephant.transform.position;
        lionPos = lion.transform.position;
        //PlayerPrefs.SetInt("animal1Star", 0);
        animal1Star = PlayerPrefs.GetInt("animal1Star");
        starGet(animal1Star);
    }

    public void DragChicken()
    {
        if (chicken.transform.position != chickenBlack.transform.position)
            chicken.transform.position = Input.mousePosition;
    }

    public void DropChicken()
    {
        float Distance = Vector3.Distance(chicken.transform.position, chickenBlack.transform.position);

        if (Distance < 50)
        {
            source.clip = correct[0];
            source.Play();
            chicken.transform.position = chickenBlack.transform.position;

            animal1Star = PlayerPrefs.GetInt("animal1Star");
            if (animal1Star < 3) { 
                PlayerPrefs.SetInt("animal1Star", animal1Star + 1);
                starGet(animal1Star + 1);
            }
        }
        else
        {
            chicken.transform.position = chickenPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    public void DragElephant()
    {
        if (elephant.transform.position != elephantBlack.transform.position)
            elephant.transform.position = Input.mousePosition;
    }

    public void DropElephant()
    {
        float Distance = Vector3.Distance(elephant.transform.position, elephantBlack.transform.position);

        if (Distance < 50)
        {
            source.clip = correct[1];
            source.Play();
            elephant.transform.position = elephantBlack.transform.position;

            animal1Star = PlayerPrefs.GetInt("animal1Star");
            if (animal1Star < 3) { 
                PlayerPrefs.SetInt("animal1Star", animal1Star + 1);
            starGet(animal1Star + 1);
            }
        }
        else
        {
            elephant.transform.position = elephantPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    public void DragLion()
    {
        if (lion.transform.position != lionBlack.transform.position)
            lion.transform.position = Input.mousePosition;
    }

    public void DropLion()
    {
        float Distance = Vector3.Distance(lion.transform.position, lionBlack.transform.position);

        if (Distance < 50)
        {
            source.clip = correct[2];
            source.Play();
            lion.transform.position = lionBlack.transform.position;

            animal1Star = PlayerPrefs.GetInt("animal1Star");
            if (animal1Star < 3) { 
                PlayerPrefs.SetInt("animal1Star", animal1Star + 1);
                starGet(animal1Star + 1);
            }
        }
        else
        {
            lion.transform.position = lionPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    void starGet(int animal2Star)
    {
        if (animal2Star == 3)
        {
            PlayerPrefs.SetInt("animal1Star", 3);
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);

        }
        else if (animal2Star == 2)
        {
            star1.SetActive(true);
            star2.SetActive(true);
        }
        else if (animal2Star == 1)
        {
            star1.SetActive(true);
        }
    }
}
