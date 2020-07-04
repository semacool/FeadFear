using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class Pausemenu : MonoBehaviour
{

    public GameObject pause;
    public GameObject PauseName;

    void Start()
    {
        Advertisement.Initialize("3308643",false);

        pause.SetActive(false);
        PauseName.SetActive(false);

    }

    // Update is called once per frame



    public  void ClickOnPause()
    {
        Time.timeScale = 0f;
        pause.SetActive(true);
        PauseName.SetActive(true);

    }
    public void ClickOnRetry()
    {
        Advertisement.Show();
        SceneManager.LoadScene(1);
    }
    public void ClickOnMenu()
    {
        Advertisement.Show();
        SceneManager.LoadScene(0);
    }

    public void ClickOnContinue()
    {
        pause.SetActive(false);
        PauseName.SetActive(false);
        Time.timeScale = 1f;

    }

    public void ClickOnMusic()
    {
        if (AudioListener.volume == 0)
        {
            AudioListener.volume = 1f;
        }
        else
        {
            AudioListener.volume = 0;
        }
    }


}
