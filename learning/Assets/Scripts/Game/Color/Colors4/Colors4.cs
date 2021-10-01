using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Colors4 : MonoBehaviour
{
    public GameObject questionSound1, questionSound2, questionSound3;
    public GameObject star1, star2, star3, board;

    public List<GameObject> units = new List<GameObject>();

    private GameObject tempBalloon;
    float balloonCreatTime = 1.2f;
    float timer = 0f, destoryTime = 3f, time2 = 0;
    private int color4Star, randomNumber = 0;

    public Slider starSlider;

    void Start()
    {
        color4Star = PlayerPrefs.GetInt("color4Star");
         starGet(color4Star);
         SoundGet(color4Star);

        units[0].transform.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(30f, 80f), 0));
        units[1].transform.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(30f, 80f), 0));
        units[2].transform.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(30f, 80f), 0));
        units[3].transform.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(30f, 80f), 0));

        starSlider.maxValue = 10;

    }

    void Update()
    {
        timer -= Time.deltaTime;
        if(timer < 0)
        {
            GameObject go = Instantiate(units[randomNumber], new Vector3(Random.Range(-9f, 8f), -6f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            
            go.SetActive(true);

            go.transform.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(30f, 80f), 0));

            if(randomNumber == 0 || randomNumber == 1) {
                randomNumber = Random.Range(2, 4);
            }
            else{
                randomNumber = Random.Range(0, 2);
            }
            timer = balloonCreatTime;
        }


      

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(touch.position), Vector2.zero);

                if (hit.collider != null && hit.collider.tag == "blueBalloon" && color4Star == 0)
                {
                    tempBalloon = hit.collider.gameObject;
                    tempBalloon.transform.GetChild(0).position = tempBalloon.transform.position;
                    tempBalloon.transform.GetChild(0).gameObject.SetActive(true);
                    
                    starSlider.value += 1;
                    while (destoryTime <= time2)
                    {
                        time2 += Time.deltaTime;
                    }

                    time2 = 0;

                    Destroy(tempBalloon);

                    if (starSlider.value == starSlider.maxValue)
                    {
                        color4Star = 1;
                        starGet(color4Star);
                        SoundGet(color4Star);
                        starSlider.value = 0;
                    }
                }

                else if (hit.collider != null && hit.collider.tag == "greenBalloon" && color4Star == 1)
                {
                    tempBalloon = hit.collider.gameObject;
                    tempBalloon.transform.GetChild(0).position = tempBalloon.transform.position;
                    tempBalloon.transform.GetChild(0).gameObject.SetActive(true);

                    starSlider.value += 1;

                    while (destoryTime <= time2)
                    {
                        time2 += Time.deltaTime;
                    }

                    time2 = 0;

                    Destroy(tempBalloon);

                    if (starSlider.value == starSlider.maxValue)
                    {
                        color4Star = 2;
                        starGet(color4Star);
                        SoundGet(color4Star);
                        starSlider.value = 0;
                    }
                }

                else if (hit.collider != null && hit.collider.tag == "redBalloon" && color4Star == 2)
                {
                    tempBalloon = hit.collider.gameObject;
                    tempBalloon.transform.GetChild(0).position = tempBalloon.transform.position;
                    tempBalloon.transform.GetChild(0).gameObject.SetActive(true);

                    starSlider.value += 1;
                    while (destoryTime <= time2)
                    {
                        time2 += Time.deltaTime;
                    }

                    time2 = 0;

                    Destroy(tempBalloon);

                    if (starSlider.value == starSlider.maxValue)
                    {
                        color4Star = 3;
                        starGet(color4Star);
                        SoundGet(color4Star);
                        starSlider.value = 0;
                    }
                }

                else if (hit.collider != null)
                {
                    tempBalloon = hit.collider.gameObject;
                    tempBalloon.transform.GetChild(0).position = tempBalloon.transform.position;
                    tempBalloon.transform.GetChild(0).gameObject.SetActive(true);
                    Destroy(tempBalloon);
                    starSlider.value = starSlider.value - 1;
                    SoundGet(color4Star);
                }
            }
        }
    }

    private void starGet(int color4Star)
    {
        if (color4Star == 3)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
            board.SetActive(true);

        }
        else if (color4Star == 2)
        {
            star1.SetActive(true);
            star2.SetActive(true);
        }
        else if (color4Star == 1)
        {
            star1.SetActive(true);
        }
    }
    
    private void SoundGet(int color4Star)
    {

        if (color4Star == 0)
        {
            questionSound1.SetActive(true);
            questionSound2.SetActive(false);
            questionSound3.SetActive(false);
        }
        else if (color4Star == 1)
        {
            questionSound1.SetActive(false);
            questionSound2.SetActive(true);
            questionSound3.SetActive(false);
        }
        else if (color4Star == 2)
        {
            questionSound1.SetActive(false);
            questionSound2.SetActive(false);
            questionSound3.SetActive(true);
        }
        else if (color4Star == 3)
        {
            questionSound1.SetActive(false);
            questionSound2.SetActive(false);
            questionSound3.SetActive(false);
        }
    }
}
