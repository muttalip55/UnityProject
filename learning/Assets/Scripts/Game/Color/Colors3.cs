using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Colors3 : MonoBehaviour
{
    public GameObject star1, star2, star3;
    public Text questionText;
    int color3Star;
    private readonly string misson1 = "Turuncu", misson2 = "Sarı", misson3 = "Kırmızı";

    public GameObject questionSound1, questionSound2, questionSound3, congratulationsSound;

    void Start()
    {
       // PlayerPrefs.SetInt("color3Star", 0);
        color3Star = PlayerPrefs.GetInt("color3Star");
        starGet(color3Star);
        questionSound1.SetActive(false);
        questionSound2.SetActive(false);
        questionSound3.SetActive(false);
        congratulationsSound.SetActive(false);
        SoundGet(color3Star);
    }
    void Update()
    {
        color3Star = PlayerPrefs.GetInt("color3Star");
        question();

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            

            if (hit.collider != null && hit.collider.tag == "orange" && color3Star == 0)
            {
                star1.SetActive(true);
                PlayerPrefs.SetInt("color3Star", 1);
                color3Star = PlayerPrefs.GetInt("color3Star");
                SoundGet(color3Star);
            }

            else if (hit.collider != null && hit.collider.tag == "yellow" && color3Star == 1)
            {
                star2.SetActive(true);
                PlayerPrefs.SetInt("color3Star", 2);
                color3Star = PlayerPrefs.GetInt("color3Star");
                SoundGet(color3Star);
            }

            else if (hit.collider != null && hit.collider.tag == "red" && color3Star == 2)
            {
                star3.SetActive(true);
                PlayerPrefs.SetInt("color3Star", 3);
                color3Star = PlayerPrefs.GetInt("color3Star");
                SoundGet(color3Star);
            }
            else
            {
                //hata mesaji //hatta ses fonksiyonunu cagirabiliriz
            }
        }
    }

    private void question()
    {
        if (color3Star == 0)
            questionText.text = "Lütfen " + misson1 + " rengi seçiniz";
        else if (color3Star == 2)
            questionText.text = "Lütfen " + misson3 + " rengi seçiniz";
        else if (color3Star == 1)
            questionText.text = "Lütfen " + misson2 + " rengi seçiniz";
        else
            questionText.text = "TEBRİKLER!!!";
    }

    void starGet(int color3Star)
    {
        if (color3Star == 3)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);

        }
        else if (color3Star == 2)
        {
            star1.SetActive(true);
            star2.SetActive(true);
        }
        else if (color3Star == 1)
        {
            star1.SetActive(true);
        }
    }

    void SoundGet(int color3Star)
    {
        if (color3Star == 0)
        {
            questionSound1.SetActive(true);
            questionSound2.SetActive(false);
            questionSound3.SetActive(false);
        }
        else if (color3Star == 1)
        {
            questionSound1.SetActive(false);
            questionSound2.SetActive(true);
            questionSound3.SetActive(false);
        }
        else if (color3Star == 2)
        {
            questionSound1.SetActive(false);
            questionSound2.SetActive(false);
            questionSound3.SetActive(true);
        }
        else if (color3Star == 3)
        {
            questionSound1.SetActive(false);
            questionSound2.SetActive(false);
            questionSound3.SetActive(false);
            congratulationsSound.SetActive(true);
        }
    }
}
