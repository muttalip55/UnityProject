using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FishingRodanager : MonoBehaviour
{
    public GameObject star1, star2, star3, GameOver, timerSound;
    public GameObject Boardstar1, Boardstar2, Boardstar3;
    public int i, number2Star;
    public int misson1, misson2, misson3;
    private float time;
    public Text timeText, questionText, overText;
    public GameObject questionSound1, questionSound2, questionSound3;
    private bool win;
    public Animator anim;

    public GameObject timeSand;
    public Slider timeSlider;
    private Vector3 temptimeSand2, temptimeSand1;
    private float lefTimeSand;

    void Start()
    {
       // PlayerPrefs.SetInt("number2Star", 0);
        number2Star = PlayerPrefs.GetInt("number2Star");
        starGet(number2Star);
        SoundGet(number2Star);
        time = 15;
        timeText.text = "" + (int)time;
        win = false;
        timerSound.SetActive(false);

        temptimeSand2 = timeSand.transform.position;
        temptimeSand1 = timeSand.transform.position;

        lefTimeSand = temptimeSand2.x / (time + 2);

        timeSlider.maxValue = time;
        timeSlider.value = time;
    }

    // Update is called once per frame
    void Update()
    {
        number2Star = PlayerPrefs.GetInt("number2Star");
        timer();
        question();
    }
    private void question()
    {
        if (number2Star == 0)
            questionText.text = "Lütfen " + misson1 + " balık tutunuz";
        else if (number2Star == 2)
            questionText.text = "Lütfen " + misson3 + "  balık tutunuz";
        else if (number2Star == 1)
            questionText.text = "Lütfen " + misson2 + " balık tutunuz";
        else
            questionText.text = "TEBRİKLER!!!";
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        i++;
        anim = other.gameObject.GetComponent<Animator>();
        anim.enabled = true;
        anim.Play("FishingAnimation");
    }

    public void timer()
    {
        SoundGet(number2Star);

        if (time >= 0)
        {
            time -= Time.deltaTime;
            timeSlider.value = time;

            temptimeSand2.x -= Time.deltaTime * lefTimeSand;
            timeSand.transform.position = temptimeSand2;

            timeText.color = Color.black;
            timeText.text = "" + (int)time;
            if (time <= 6)
                timeText.color = Color.red;
            if (time <= 3)
                timerSound.SetActive(true);
        }
        if (time < 0)
        {
            if (number2Star == 0 && misson1 == i)
            {
                star1.SetActive(true);
                PlayerPrefs.SetInt("number2Star", 1);
                i = 0;
                win = true;
            }

            else if (number2Star == 1 && misson2 == i)
            {
                star2.SetActive(true);
                PlayerPrefs.SetInt("number2Star", 2);
                i = 0;
                win = true;
            }

            else if (number2Star == 2 && misson3 == i)
            {
                star3.SetActive(true);
                PlayerPrefs.SetInt("number2Star", 3);
                i = 0;
                win = false;
            }
            timerSound.SetActive(false);
        }

        if (time < 0 && win == false)
        {
            GameOver.SetActive(true);
            BoardStarControl();
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

    void BoardStarControl()
    {
        if (number2Star == 3)
        {
            overText.text = "sonraki bölüme geçebilirsiniz";
            Boardstar1.SetActive(true);
            Boardstar2.SetActive(true);
            Boardstar3.SetActive(true);
        }
        else if (number2Star == 2)
        {
            Boardstar1.SetActive(true);
            Boardstar2.SetActive(true);
        }
        else if (number2Star == 1)
        {
            Boardstar1.SetActive(true);
        }
    }

    private void SoundGet(int number2Star)
    {
        if (number2Star == 0)
        {
            questionSound1.SetActive(true);
            questionSound2.SetActive(false);
            questionSound3.SetActive(false);
        }
        else if (number2Star == 1)
        {
            questionSound1.SetActive(false);
            questionSound2.SetActive(true);
            questionSound3.SetActive(false);
        }
        else if (number2Star == 2)
        {
            questionSound1.SetActive(false);
            questionSound2.SetActive(false);
            questionSound3.SetActive(true);
        }
        else if (number2Star == 3)
        {
            questionSound1.SetActive(false);
            questionSound2.SetActive(false);
            questionSound3.SetActive(false);
        }
    }

    private void starGet(object color1Star)
    {
        if (number2Star == 3)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);

        }
        else if (number2Star == 2)
        {
            star1.SetActive(true);
            star2.SetActive(true);
        }
        else if (number2Star == 1)
        {
            star1.SetActive(true);
        }
    }
}

