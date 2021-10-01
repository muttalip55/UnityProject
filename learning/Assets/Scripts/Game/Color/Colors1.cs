using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Colors1 : MonoBehaviour
{
    public GameObject star1, star2, star3;
    public Text questionText;
    int color1Star;
    private readonly string misson1 = "Sarı", misson2 = "Beyaz", misson3 = "Kırmızı";

    public GameObject questionSound1, questionSound2, questionSound3, congratulationsSound;

    void Start()
    {
        //PlayerPrefs.SetInt("color1Star", 0);
        color1Star = PlayerPrefs.GetInt("color1Star");
        starGet(color1Star);
        questionSound1.SetActive(false);
        questionSound2.SetActive(false);
        questionSound3.SetActive(false);
        congratulationsSound.SetActive(false);
        SoundGet(color1Star);
    }
    void Update()
    {
        color1Star = PlayerPrefs.GetInt("color1Star");
        question();
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            if (hit.collider != null && hit.collider.tag == "yellow" && color1Star == 0)
            {
                star1.SetActive(true);
                PlayerPrefs.SetInt("color1Star", 1);
                color1Star = PlayerPrefs.GetInt("color1Star");
                SoundGet(color1Star);

            }

            else if (hit.collider != null && hit.collider.tag == "white" && color1Star == 1)
            {
                star2.SetActive(true);
                PlayerPrefs.SetInt("color1Star", 2);
                color1Star = PlayerPrefs.GetInt("color1Star");
                SoundGet(color1Star);
            }

            else if (hit.collider != null && hit.collider.tag == "red" && color1Star == 2)
            {
                star3.SetActive(true);
                PlayerPrefs.SetInt("color1Star", 3);
                color1Star = PlayerPrefs.GetInt("color1Star");
                SoundGet(color1Star);
            }
        }
        
    }

    private void question()
    {
        if (color1Star == 0)
            questionText.text = "Lütfen " + misson1 + " rengi seçiniz";
        else if(color1Star == 2)
            questionText.text = "Lütfen " + misson3 + " rengi seçiniz";
        else if (color1Star == 1)
            questionText.text = "Lütfen " + misson2 + " rengi seçiniz";
        else
            questionText.text = "TEBRİKLER!!!";
    }

    void starGet(int colorStar)
    {
        if (colorStar == 3)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);

        }
        else if (colorStar == 2)
        {
            star1.SetActive(true);
            star2.SetActive(true);
        }
        else if (colorStar == 1)
        {
            star1.SetActive(true);
        }
    }

    void SoundGet(int colorStar)
    {
        if (colorStar == 0)
        {
            questionSound1.SetActive(true);
            questionSound2.SetActive(false);
            questionSound3.SetActive(false);
        }
        else if (colorStar == 1)
        {
            questionSound1.SetActive(false);
            questionSound2.SetActive(true);
            questionSound3.SetActive(false);
        }
        else if (colorStar == 2)
        {
            questionSound1.SetActive(false);
            questionSound2.SetActive(false);
            questionSound3.SetActive(true);
        }
        else if (colorStar == 3)
        {
            questionSound1.SetActive(false);
            questionSound2.SetActive(false);
            questionSound3.SetActive(false);
            congratulationsSound.SetActive(true);
        }
    }
}
