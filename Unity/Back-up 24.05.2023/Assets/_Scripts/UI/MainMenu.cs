using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    /*
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    */

    //to load map selection
    public void PlayGame()
    {
        MapLoader.Load(MapLoader.Scene.BikeSelectScene);
        //MapLoader.Load(MapLoader.Scene.SceneSelect);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
