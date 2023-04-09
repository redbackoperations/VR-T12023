using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{
    public GameObject MissionFailUI;
    public GameObject Manager;
    public int countstart = 50;
    public Text timerUI;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("countTimer",2);
    }

    void countTimer() {
        if (countstart > 0)
        {
            TimeSpan spanTime = TimeSpan.FromSeconds(countstart);
            timerUI.text = "Timer :" + spanTime.Minutes + ":" + spanTime.Seconds;
            // Debug.Log("Timer :" + countstart);
            countstart--;
            Invoke("countTimer", 1.0f);
            
        }
        else
        {
            Manager.SetActive(false);
            MissionFail();
           // timerUI.text = "Mission fail";
            Invoke("Menu", 2.0f);
        }

    }
    void Menu() {
        SceneManager.LoadScene("GameMenu");
    }
    public void MissionFail()
    {
        MissionFailUI.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
