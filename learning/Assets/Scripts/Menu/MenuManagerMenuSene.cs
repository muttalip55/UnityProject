using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagerMenuSene : MonoBehaviour
{
    public GameObject animalsBoard, colorsBoard, numbersBoard;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AnimalsButton()
    {
        animalsBoard.SetActive(true);
    }

    public void ColorsButton()
    {
        colorsBoard.SetActive(true);
    }

    public void NumbersButton()
    {
        numbersBoard.SetActive(true);
    }

    public void XAnimalButton()
    {
        animalsBoard.SetActive(false);
    }

    public void XColorButton()
    {
        colorsBoard.SetActive(false);
    }

    public void XNumberButton()
    {
        numbersBoard.SetActive(false);
    }

    public void Animals1()
    {
        SceneManager.LoadScene(1);
    }

    public void Animals2()
    {
        SceneManager.LoadScene(2);
    }

    public void Animals3()
    {
        SceneManager.LoadScene(3);
    }

    public void Colors1()
    {
        SceneManager.LoadScene(4);
    }

    public void Colors2()
    {
        SceneManager.LoadScene(5);
    }

    public void Colors3()
    {
        SceneManager.LoadScene(6);
    }

    public void Colors4()
    {
        SceneManager.LoadScene(7);
    }

    public void Numbers1()
    {
        SceneManager.LoadScene(8);
    }

    public void Numbers2()
    {
        SceneManager.LoadScene(9);
    }

    public void Numbers3()
    {
        SceneManager.LoadScene(10);
    }

    public void Numbers4()
    {
        SceneManager.LoadScene(11);
    }
}
