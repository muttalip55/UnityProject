using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasketManager : MonoBehaviour
{
    public GameObject star1, star2, star3, GameOver, timerSound;
    public GameObject Boardstar1, Boardstar2, Boardstar3;
    public int i,number1Star;
    public int misson1, misson2, misson3;
    private float time;
    public Text timeText, questionText, overText;
    private bool win;
    public GameObject questionSound1, questionSound2, questionSound3;

    public GameObject timeSand;
    public Slider timeSlider;
    private Vector3 temptimeSand2, temptimeSand1;
   // private float lefTimeSand;

    void Start()
    {
        //PlayerPrefs.SetInt("number1Star", 0);
        number1Star = PlayerPrefs.GetInt("number1Star");
        starGet(number1Star);
        SoundGet(number1Star);
        time = 15;
        timeText.text = "" + (int)time;
        win = false;
        timerSound.SetActive(false);


       // lefTimeSand = temptimeSand2.x / (time + 2);

        timeSlider.maxValue = time;
        timeSlider.value = time;
    }

    void Update()
    {  
        number1Star = PlayerPrefs.GetInt("number1Star");
        timer();
        question();
    }

    private void question()
    {
        if (number1Star == 0)
            questionText.text = "Lütfen " + misson1 + " elma toplayın";
        else if(number1Star == 2)
            questionText.text = "Lütfen " + misson3 + " elma toplayın";
        else if (number1Star == 1)
            questionText.text = "Lütfen " + misson2 + " elma toplayın";
        else
            questionText.text = "TEBRİKLER!!!";
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        i++;
        Destroy(other.gameObject);
    }

    public void timer()
    {
        SoundGet(number1Star);

        if (time >= 0) { 
        time -= Time.deltaTime;
            timeSlider.value = time;


            timeText.color = Color.black;
            timeText.text = "" + (int)time;
            if (time <= 6)
                timeText.color = Color.red;
            if (time <= 3)
                timerSound.SetActive(true);
        }
        if(time < 0)
        {
            if (number1Star == 0 && misson1 == i)
            {
                star1.SetActive(true);
                PlayerPrefs.SetInt("number1Star", 1);
                i = 0;
                win = true;
            }

            else if (number1Star == 1 && misson2 == i)
            {
                star2.SetActive(true);
                PlayerPrefs.SetInt("number1Star", 2);
                i = 0;
                win = true;
            }

            else if (number1Star == 2 && misson3 == i)
            {
                star3.SetActive(true);
                PlayerPrefs.SetInt("number1Star", 3);
                i = 0;
                win = false;
            }
            timerSound.SetActive(false);
        }

        if (time < 0 && win == false)
        {
            GameOver.SetActive(true);
            boardStarControl();
        }

        if (time < 0 && win == true)
        {
            timeSand.transform.position = temptimeSand1;
            temptimeSand2 = temptimeSand1;
            time = 15;
            timeText.text = "" + (int)time;
            win = false;
        }
        if (time > 3 && time < 0)
            timerSound.SetActive(false);
    }

    void boardStarControl()
    {
        if (number1Star == 3)
        {
            overText.text = "sonraki bölüme geçebilirsiniz";
            Boardstar1.SetActive(true);
            Boardstar2.SetActive(true);
            Boardstar3.SetActive(true);
        }
        else if (number1Star == 2)
        {
            Boardstar1.SetActive(true);
            Boardstar2.SetActive(true);
        }
        else if (number1Star == 1)
        {
            Boardstar1.SetActive(true);
        }
    }

    private void SoundGet(int number1Star)
    {

        if (number1Star == 0)
        {
            questionSound1.SetActive(true);
            questionSound2.SetActive(false);
            questionSound3.SetActive(false);
        }
        else if (number1Star == 1)
        {
            questionSound1.SetActive(false);
            questionSound2.SetActive(true);
            questionSound3.SetActive(false);
        }
        else if (number1Star == 2)
        {
            questionSound1.SetActive(false);
            questionSound2.SetActive(false);
            questionSound3.SetActive(true);
        }
        else if (number1Star == 3)
        {
            questionSound1.SetActive(false);
            questionSound2.SetActive(false);
            questionSound3.SetActive(false);
        }
    }

    private void starGet(int number1Star)
    {
        if (number1Star == 3)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);

        }
        else if (number1Star == 2)
        {
            star1.SetActive(true);
            star2.SetActive(true);
        }
        else if (number1Star == 1)
        {
            star1.SetActive(true);
        }
    }
}
    
