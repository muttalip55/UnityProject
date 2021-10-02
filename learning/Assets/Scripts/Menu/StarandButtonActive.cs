using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarandButtonActive : MonoBehaviour
{
    public GameObject Color1Star1, Color1Star2, Color1Star3;
    public GameObject Color2Star1, Color2Star2, Color2Star3;
    public GameObject Color3Star1, Color3Star2, Color3Star3;
    public GameObject Color4Star1, Color4Star2, Color4Star3;
    public GameObject Color5Star1, Color5Star2, Color5Star3;
    public GameObject Color6Star1, Color6Star2, Color6Star3;

    public GameObject Number1Star1, Number1Star2, Number1Star3;
    public GameObject Number2Star1, Number2Star2, Number2Star3;
    public GameObject Number3Star1, Number3Star2, Number3Star3;
    public GameObject Number4Star1, Number4Star2, Number4Star3;

    public GameObject Animal1Star1, Animal1Star2, Animal1Star3;
    public GameObject Animal2Star1, Animal2Star2, Animal2Star3;
    public GameObject Animal3Star1, Animal3Star2, Animal3Star3;
    public GameObject Animal4Star1, Animal4Star2, Animal4Star3;
    public GameObject Animal5Star1, Animal5Star2, Animal5Star3;
    public GameObject Animal6Star1, Animal6Star2, Animal6Star3;
    public GameObject Animal7Star1, Animal7Star2, Animal7Star3;
    public GameObject Animal8Star1, Animal8Star2, Animal8Star3;

    private int color1Star, color2Star, color3Star, color4Star, color5Star, color6Star;
    private int animal1Star, animal2Star, animal3Star, animal4Star, animal5Star, animal6Star, animal7Star, animal8Star;
    private int number1Star,number2Star,number3Star, number4Star;

    public Button color2GameButton, color3GameButton, color4GameButton, color5GameButton, color6GameButton;

    public Button number2GameButton, number3GameButton, number4GameButton;

    public Button animal2GameButton, animal3GameButton, animal4GameButton, animal5GameButton, animal6GameButton, animal7GameButton, animal8GameButton;
    // Start is called before the first frame update
    void Start()
    {
        color1Game();
        color2Game();
        color3Game();
        color4Game();
        color5Game();
        color6Game();

        animal1Game();
        animal2Game();
        animal3Game();
        animal4Game();

        number1Game();
        number2Game();
        number3Game();
        number4Game();
    }

    private void number4Game()
    {
        if (PlayerPrefs.HasKey("number4Star"))
            number4Star = PlayerPrefs.GetInt("number4Star");
        else
            PlayerPrefs.SetInt("number4Star", 0);

        Number4StarActive(number4Star);
    }

    private void number3Game()
    {
        if (PlayerPrefs.HasKey("number3Star"))
            number3Star = PlayerPrefs.GetInt("number3Star");
        else
            PlayerPrefs.SetInt("number3Star", 0);

        Number3StarActive(number3Star);
    }

    private void number2Game()
    {
        if (PlayerPrefs.HasKey("number2Star"))
            number2Star = PlayerPrefs.GetInt("number2Star");
        else
            PlayerPrefs.SetInt("number2Star", 0);

        Number2StarActive(number2Star);
    }

    private void number1Game()
    {
        if (PlayerPrefs.HasKey("number1Star"))
            number1Star = PlayerPrefs.GetInt("number1Star");
        else
            PlayerPrefs.SetInt("number1Star", 0);

        Debug.Log("number1Game : " + number1Star);
        Number1StarActive(number1Star);
    }

    /// <summary>
    ///                                     ANIMALS
    /// </summary>

    private void animal8Game()
    {
        if (PlayerPrefs.HasKey("animal8Star"))
            animal3Star = PlayerPrefs.GetInt("animal8Star");
        else
            PlayerPrefs.SetInt("animal8Star", 0);

        Animal8StarActive(animal8Star);
    }

    private void animal7Game()
    {
        if (PlayerPrefs.HasKey("animal7Star"))
            animal7Star = PlayerPrefs.GetInt("animal7Star");
        else
            PlayerPrefs.SetInt("animal7Star", 0);

        Animal7StarActive(animal7Star);
    }
    private void animal6Game()
    {
        if (PlayerPrefs.HasKey("animal6Star"))
            animal6Star = PlayerPrefs.GetInt("animal6Star");
        else
            PlayerPrefs.SetInt("animal6Star", 0);

        Animal6StarActive(animal6Star);
    }

    private void animal5Game()
    {
        if (PlayerPrefs.HasKey("animal5Star"))
            animal5Star = PlayerPrefs.GetInt("animal5Star");
        else
            PlayerPrefs.SetInt("animal5Star", 0);

        Animal5StarActive(animal5Star);
    }

    private void animal4Game()
    {
        if (PlayerPrefs.HasKey("animal4Star"))
            animal4Star = PlayerPrefs.GetInt("animal4Star");
        else
            PlayerPrefs.SetInt("animal4Star", 0);

        Animal4StarActive(animal4Star);
    }

    private void animal3Game()
    {
        if (PlayerPrefs.HasKey("animal3Star"))
            animal3Star = PlayerPrefs.GetInt("animal3Star");
        else
            PlayerPrefs.SetInt("animal3Star", 0);

        Animal3StarActive(animal3Star);
    }

    private void animal2Game()
    {
        if (PlayerPrefs.HasKey("animal2Star"))
            animal2Star = PlayerPrefs.GetInt("animal2Star");
        else
            PlayerPrefs.SetInt("animal2Star", 0);

        Animal2StarActive(animal2Star);
    }

    private void animal1Game()
    {
        if (PlayerPrefs.HasKey("animal1Star"))
            animal1Star = PlayerPrefs.GetInt("animal1Star");
        else
            PlayerPrefs.SetInt("animal1Star", 0);

        Animal1StarActive(animal1Star);
    }


    /// <summary>
    ///                                    /////////////////////// COLORS//////////////////////////////////////
    /// </summary>
    private void color3Game()
    {
        if (PlayerPrefs.HasKey("color3Star"))
            color3Star = PlayerPrefs.GetInt("color3Star");
        else
            PlayerPrefs.SetInt("color3Star", 0);
        Color3StarActive(color3Star);
    }

    private void color6Game()
    {
        if (PlayerPrefs.HasKey("color6Star"))
            color3Star = PlayerPrefs.GetInt("color6Star");
        else
            PlayerPrefs.SetInt("color6Star", 0);
        Color6StarActive(color6Star);
    }

    private void color5Game()
    {
        if (PlayerPrefs.HasKey("color5Star"))
            color5Star = PlayerPrefs.GetInt("color5Star");
        else
            PlayerPrefs.SetInt("color5Star", 0);
        Color5StarActive(color5Star);
    }

    private void color4Game()
    {
        if (PlayerPrefs.HasKey("color4Star"))
            color3Star = PlayerPrefs.GetInt("color4Star");
        else
            PlayerPrefs.SetInt("color4Star", 0);
        Color4StarActive(color4Star);
    }

    private void color1Game()
    {
        if (PlayerPrefs.HasKey("color1Star"))
            color1Star = PlayerPrefs.GetInt("color1Star");
        else
            PlayerPrefs.SetInt("color1Star", 0);

        Color1StarActive(color1Star);
    }

    private void color2Game()
    {
        if (PlayerPrefs.HasKey("color2Star"))
            color2Star = PlayerPrefs.GetInt("color2Star");
        else
            PlayerPrefs.SetInt("color2Star", 0);
        Color2StarActive(color2Star);
    }


    private void Color1StarActive(int colorStar)
    {
        if (colorStar == 3)
        {
            Color1Star1.SetActive(true);
            Color1Star2.SetActive(true);
            Color1Star3.SetActive(true);
            color2GameButton.interactable = true;

        }
        else if (colorStar == 2)
        {
            Color1Star1.SetActive(true);
            Color1Star2.SetActive(true);
        }
        else if (colorStar == 1)
        {
            Color1Star1.SetActive(true);
        }
    }

    private void Color2StarActive(int colorStar)
    {
        if (colorStar == 3)
        {
            Color2Star1.SetActive(true);
            Color2Star2.SetActive(true);
            Color2Star3.SetActive(true);
            color3GameButton.interactable = true;

        }
        else if (colorStar == 2)
        {
            Color2Star1.SetActive(true);
            Color2Star2.SetActive(true);
        }
        else if (colorStar == 1)
        {
            Color2Star1.SetActive(true);
        }
    }

    private void Color3StarActive(int colorStar)
    {
        if (colorStar == 3)
        {
            Color3Star1.SetActive(true);
            Color3Star2.SetActive(true);
            Color3Star3.SetActive(true);
            color4GameButton.interactable = true;

        }
        else if (colorStar == 2)
        {
            Color3Star1.SetActive(true);
            Color3Star2.SetActive(true);
        }
        else if (colorStar == 1)
        {
            Color3Star1.SetActive(true);
        }
    }

    private void Color4StarActive(int colorStar)
    {
        if (colorStar == 3)
        {
            Color4Star1.SetActive(true);
            Color4Star2.SetActive(true);
            Color4Star3.SetActive(true);
            color5GameButton.interactable = true;

        }
        else if (colorStar == 2)
        {
            Color4Star1.SetActive(true);
            Color4Star2.SetActive(true);
        }
        else if (colorStar == 1)
        {
            Color4Star1.SetActive(true);
        }
    }

    private void Color5StarActive(int colorStar)
    {
        if (colorStar == 3)
        {
            Color5Star1.SetActive(true);
            Color5Star2.SetActive(true);
            Color5Star3.SetActive(true);
            color6GameButton.interactable = true;

        }
        else if (colorStar == 2)
        {
            Color5Star1.SetActive(true);
            Color5Star2.SetActive(true);
        }
        else if (colorStar == 1)
        {
            Color5Star1.SetActive(true);
        }
    }

    private void Color6StarActive(int colorStar)
    {
        if (colorStar == 3)
        {
            Color6Star1.SetActive(true);
            Color6Star2.SetActive(true);
            Color6Star3.SetActive(true);
        }
        else if (colorStar == 2)
        {
            Color6Star1.SetActive(true);
            Color6Star2.SetActive(true);
        }
        else if (colorStar == 1)
        {
            Color5Star1.SetActive(true);
        }
    }
   
    
    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    private void Number1StarActive(int numberStar)
    {
        if (numberStar == 3)
        {
            Number1Star1.SetActive(true);
            Number1Star2.SetActive(true);
            Number1Star3.SetActive(true);
            number2GameButton.interactable = true;

        }
        else if (numberStar == 2)
        {
            Number1Star1.SetActive(true);
            Number1Star2.SetActive(true);
        }
        else if (numberStar == 1)
        {
            Number1Star1.SetActive(true);
        }
        else if (numberStar == 0)
        {
            Number1Star1.SetActive(false);
            Number1Star2.SetActive(false);
            Number1Star3.SetActive(false);
        }
    }

    private void Number2StarActive(int numberStar)
    {
        if (numberStar == 3)
        {
            Number2Star1.SetActive(true);
            Number2Star2.SetActive(true);
            Number2Star3.SetActive(true);
            number3GameButton.interactable = true;

        }
        else if (numberStar == 2)
        {
            Number2Star1.SetActive(true);
            Number2Star2.SetActive(true);
        }
        else if (numberStar == 1)
        {
            Number2Star1.SetActive(true);
        }
    }

    private void Number3StarActive(int numberStar)
    {
        if (numberStar == 3)
        {
            Number3Star1.SetActive(true);
            Number3Star2.SetActive(true);
            Number3Star3.SetActive(true);
            number4GameButton.interactable = true;
        }
        else if (numberStar == 2)
        {
            Number3Star1.SetActive(true);
            Number3Star2.SetActive(true);
        }
        else if (numberStar == 1)
        {
            Number3Star1.SetActive(true);
        }
    }

    private void Number4StarActive(int numberStar)
    {
        if (numberStar == 3)
        {
            Number4Star1.SetActive(true);
            Number4Star2.SetActive(true);
            Number4Star3.SetActive(true);
        }
        else if (numberStar == 2)
        {
            Number4Star1.SetActive(true);
            Number4Star2.SetActive(true);
        }
        else if (numberStar == 1)
        {
            Number4Star1.SetActive(true);
        }
    }

    //////////////////////////////////

    private void Animal1StarActive(int animalStar)
    {
        if (animalStar == 3)
        {
            Animal1Star1.SetActive(true);
            Animal1Star2.SetActive(true);
            Animal1Star3.SetActive(true);
            animal2GameButton.interactable = true;

        }
        else if (animalStar == 2)
        {
            Animal1Star1.SetActive(true);
            Animal1Star2.SetActive(true);
        }
        else if (animalStar == 1)
        {
            Animal1Star1.SetActive(true);
        }
    }

    private void Animal2StarActive(int animalStar)
    {
        if (animalStar == 3)
        {
            Animal2Star1.SetActive(true);
            Animal2Star2.SetActive(true);
            Animal2Star3.SetActive(true);
            animal3GameButton.interactable = true;

        }
        else if (animalStar == 2)
        {
            Animal2Star1.SetActive(true);
            Animal2Star2.SetActive(true);
        }
        else if (animalStar == 1)
        {
            Animal2Star1.SetActive(true);
        }
    }

    private void Animal3StarActive(int animalStar)
    {
        if (animalStar == 3)
        {
            Animal3Star1.SetActive(true);
            Animal3Star2.SetActive(true);
            Animal3Star3.SetActive(true);
            animal4GameButton.interactable = true;
        }
        else if (animalStar == 2)
        {
            Animal3Star1.SetActive(true);
            Animal3Star2.SetActive(true);
        }
        else if (animalStar == 1)
        {
            Animal3Star1.SetActive(true);
        }
    }

    private void Animal4StarActive(int animalStar)
    {
        if (animalStar == 3)
        {
            Animal4Star1.SetActive(true);
            Animal4Star2.SetActive(true);
            Animal4Star3.SetActive(true);
            animal5GameButton.interactable = true;
        }
        else if (animalStar == 2)
        {
            Animal4Star1.SetActive(true);
            Animal4Star2.SetActive(true);
        }
        else if (animalStar == 1)
        {
            Animal4Star1.SetActive(true);
        }
    }

    private void Animal5StarActive(int animalStar)
    {
        if (animalStar == 3)
        {
            Animal5Star1.SetActive(true);
            Animal5Star2.SetActive(true);
            Animal5Star3.SetActive(true);
            animal6GameButton.interactable = true;
        }
        else if (animalStar == 2)
        {
            Animal5Star1.SetActive(true);
            Animal5Star2.SetActive(true);
        }
        else if (animalStar == 1)
        {
            Animal5Star1.SetActive(true);
        }
    }

    private void Animal6StarActive(int animalStar)
    {
        if (animalStar == 3)
        {
            Animal6Star1.SetActive(true);
            Animal6Star2.SetActive(true);
            Animal6Star3.SetActive(true);
            animal7GameButton.interactable = true;
        }
        else if (animalStar == 2)
        {
            Animal6Star1.SetActive(true);
            Animal6Star2.SetActive(true);
        }
        else if (animalStar == 1)
        {
            Animal6Star1.SetActive(true);
        }
    }

    private void Animal7StarActive(int animalStar)
    {
        if (animalStar == 3)
        {
            Animal7Star1.SetActive(true);
            Animal7Star2.SetActive(true);
            Animal7Star3.SetActive(true);
            animal8GameButton.interactable = true;
        }
        else if (animalStar == 2)
        {
            Animal7Star1.SetActive(true);
            Animal7Star2.SetActive(true);
        }
        else if (animalStar == 1)
        {
            Animal7Star1.SetActive(true);
        }
    }

    private void Animal8StarActive(int animalStar)
    {
        if (animalStar == 3)
        {
            Animal8Star1.SetActive(true);
            Animal8Star2.SetActive(true);
            Animal8Star3.SetActive(true);
        }
        else if (animalStar == 2)
        {
            Animal8Star1.SetActive(true);
            Animal8Star2.SetActive(true);
        }
        else if (animalStar == 1)
        {
            Animal8Star1.SetActive(true);
        }
    }

    ////////////////////////////////////////////
    ///


}
