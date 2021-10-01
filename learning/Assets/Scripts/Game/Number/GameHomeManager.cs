using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameHomeManager : MonoBehaviour
{
    public void Home()
    {
        SceneManager.LoadScene(0);
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
}
