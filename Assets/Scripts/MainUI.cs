using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainUI : MonoBehaviour
{
    public Text checkButtonText;

    private void Update() 
    {
        if(Input.GetKey("escape"))
            Application.Quit();    
    }

    public void quitBtnPressed()
    {
        Application.Quit();
    }

    public void checkBtnPressed()
    {
        checkButtonText.GetComponent<Text>().text = "체크됨";
    }

    public void parkBtnPressed()
    {
        SceneManager.LoadScene("ParkScene");
    }

    public void cityBtnPressed()
    {
        SceneManager.LoadScene("CityScene");
    }

    public void mainBtnPressed()
    {
        SceneManager.LoadScene("StartScene");
    }
}
