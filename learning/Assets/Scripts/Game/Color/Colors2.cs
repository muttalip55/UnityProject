using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Colors2 : MonoBehaviour
{
    public GameObject star1, star2, star3;
    public Text questionText;
    int color2Star;
    private readonly string misson1 = "Mavi", misson2 = "Sarı", misson3 = "Pembe";

    public GameObject questionSound1, questionSound2, questionSound3, congratulationsSound;

    void Start()
    {
       // PlayerPrefs.SetInt("color2Star", 0);
        color2Star = PlayerPrefs.GetInt("color2Star");
        starGet(color2Star);
        questionSound1.SetActive(false);
        questionSound2.SetActive(false);
        questionSound3.SetActive(false);
        congratulationsSound.SetActive(false);
        SoundGet(color2Star);
    }
    void Update()
    {
        color2Star = PlayerPrefs.GetInt("color2Star");
        question();
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            if (hit.collider != null && hit.collider.tag == "blue" && color2Star == 0)
            {
                star1.SetActive(true);
                PlayerPrefs.SetInt("color2Star", 1);
                color2Star = PlayerPrefs.GetInt("color2Star");
                SoundGet(color2Star);
            }

            else if (hit.collider != null && hit.collider.tag == "yellow" && color2Star == 1)
            {
                star2.SetActive(true);
                PlayerPrefs.SetInt("color2Star", 2);
                color2Star = PlayerPrefs.GetInt("color2Star");
                SoundGet(color2Star);
            }

            else if (hit.collider != null && hit.collider.tag == "pink" && color2Star == 2)
            {
                star3.SetActive(true);
                PlayerPrefs.SetInt("color2Star", 3);
                color2Star = PlayerPrefs.GetInt("color2Star");
                SoundGet(color2Star);
            }
            else
            {
                //hata mesaji //hatta ses fonksiyonunu cagirabiliriz
            }
        }
    }

    private void question()
    {
        if (color2Star == 0)
            questionText.text = "Lütfen " + misson1 + " rengi seçiniz";
        else if (color2Star == 2)
            questionText.text = "Lütfen " + misson3 + " rengi seçiniz";
        else if (color2Star == 1)
            questionText.text = "Lütfen " + misson2 + " rengi seçiniz";
        else
            questionText.text = "TEBRİKLER!!!";
    }

    void starGet(int color2Star)
    {
        if (color2Star == 3)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);

        }
        else if (color2Star == 2)
        {
            star1.SetActive(true);
            star2.SetActive(true);
        }
        else if (color2Star == 1)
        {
            star1.SetActive(true);
        }
    }

    void SoundGet(int color2Star)
    {
        if (color2Star == 0)
        {
            questionSound1.SetActive(true);
            questionSound2.SetActive(false);
            questionSound3.SetActive(false);
        }
        else if (color2Star == 1)
        {
            questionSound1.SetActive(false);
            questionSound2.SetActive(true);
            questionSound3.SetActive(false);
        }
        else if (color2Star == 2)
        {
            questionSound1.SetActive(false);
            questionSound2.SetActive(false);
            questionSound3.SetActive(true);
        }
        else if (color2Star == 3)
        {
            questionSound1.SetActive(false);
            questionSound2.SetActive(false);
            questionSound3.SetActive(false);
            congratulationsSound.SetActive(true);
        }
    }
}
