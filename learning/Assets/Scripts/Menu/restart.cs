using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
  public void restartStar()
    {
        PlayerPrefs.SetInt("number1Star", 0);
        PlayerPrefs.SetInt("number2Star", 0);
        PlayerPrefs.SetInt("number3Star", 0);
        PlayerPrefs.SetInt("number4Star", 0);

        PlayerPrefs.SetInt("color1Star", 0);
        PlayerPrefs.SetInt("color2Star", 0);
        PlayerPrefs.SetInt("color3Star", 0);
        PlayerPrefs.SetInt("color4Star", 0);

        PlayerPrefs.SetInt("animal1Star", 0);
        PlayerPrefs.SetInt("animal2Star", 0);
        PlayerPrefs.SetInt("animal3Star", 0);

        SceneManager.LoadScene(0);
    }
}
