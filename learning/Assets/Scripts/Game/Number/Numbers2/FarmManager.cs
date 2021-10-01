using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FarmManager : MonoBehaviour
{
    public GameObject star1, star2, star3, GameOver, timerSound;
    public GameObject Boardstar1, Boardstar2, Boardstar3;
    public int i, number3Star;
    public int misson1, misson2, misson3;
    private float time;
    public Text timeText, questionText, overText;
    private bool win;

    public Slider timeSlider;
    private float lefTimeSand;
    public GameObject questionSound1, questionSound2, questionSound3;

    void Start()
    {
       // PlayerPrefs.SetInt("number3Star", 0);
        number3Star = PlayerPrefs.GetInt("number3Star");
        starGet(number3Star);
        SoundGet(number3Star);
        time = 15;
        timeText.text = "" + (int)time;
        win = false;

        timeSlider.maxValue = time;
        timeSlider.value = time;  
    }

    void Update()
    {
        number3Star = PlayerPrefs.GetInt("number3Star");
        timer();
        question();
    }
    private void question()
    {
        if (number3Star == 0)
            questionText.text = "Lütfen " + misson1 + " yumurta toplayınız";
        else if (number3Star == 2)
            questionText.text = "Lütfen " + misson3 + "  yumurta toplayınız";
        else if (number3Star == 1)
            questionText.text = "Lütfen " + misson2 + " yumurta toplayınız";
        else
            questionText.text = "TEBRİKLER!!!";
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        i++;
    }

    public void timer()
    {
        SoundGet(number3Star);

        if (time >= 0)
        {
            time -= Time.deltaTime;
            timeSlider.value = time;


            timeText.color = Color.black;
            timeText.text = "" + (int)time;
            if (time <= 6)
                timeText.color = Color.red;
            if (time <= 3)
                timerSound.SetActive(true);
        }
        if (time < 0)
        {
            if (number3Star == 0 && misson1 == i)
            {
                star1.SetActive(true);
                PlayerPrefs.SetInt("number3Star", 1);
                i = 0;
                win = true;
            }

            else if (number3Star == 1 && misson2 == i)
            {
                star2.SetActive(true);
                PlayerPrefs.SetInt("number3Star", 2);
                i = 0;
                win = true;
            }

            else if (number3Star == 2 && misson3 == i)
            {
                star3.SetActive(true);
                PlayerPrefs.SetInt("number3Star", 3);
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
            time = 15;
            
            timeText.text = "" + (int)time;
            win = false;
        }
        if (time > 3 && time < 0)
            timerSound.SetActive(false);
    }

    void boardStarControl()
    {
        if (number3Star == 3)
        {
            overText.text = "sonraki bölüme geçebilirsiniz";
            Boardstar1.SetActive(true);
            Boardstar2.SetActive(true);
            Boardstar3.SetActive(true);
        }
        else if (number3Star == 2)
        {
            Boardstar1.SetActive(true);
            Boardstar2.SetActive(true);
        }
        else if (number3Star == 1)
        {
            Boardstar1.SetActive(true);
        }
    }

    private void SoundGet(int number3Star)
    {
        if (number3Star == 0)
        {
            questionSound1.SetActive(true);
            questionSound2.SetActive(false);
            questionSound3.SetActive(false);
        }
        else if (number3Star == 1)
        {
            questionSound1.SetActive(false);
            questionSound2.SetActive(true);
            questionSound3.SetActive(false);
        }
        else if (number3Star == 2)
        {
            questionSound1.SetActive(false);
            questionSound2.SetActive(false);
            questionSound3.SetActive(true);
        }
        else if (number3Star == 3)
        {
            questionSound1.SetActive(false);
            questionSound2.SetActive(false);
            questionSound3.SetActive(false);
        }
    }

    private void starGet(int number3Star)
    {
        if (number3Star == 3)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);

        }
        else if (number3Star == 2)
        {
            star1.SetActive(true);
            star2.SetActive(true);
        }
        else if (number3Star == 1)
        {
            star1.SetActive(true);
        }
    }
}