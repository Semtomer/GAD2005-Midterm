using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject PauseButton, PausePopUp,SoundOn, SoundOff;

    void Start()
    {
        PauseButton.SetActive(true);
        PausePopUp.SetActive(false);
    }

    void Update()
    {
        
    }

    public void Turn_Start_Page_Fuction()
    {
        SceneManager.LoadScene("Start_Page");
    }

    public void Pause_Button_Fuction()
    {
        PauseButton.SetActive(false);
        PausePopUp.SetActive(true);
    }

    public void Play_Game_Fuction()
    {
        PauseButton.SetActive(true);
        PausePopUp.SetActive(false);
    }

    public void Reload_Game_Fuction()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void SoundOn_Fuction()
    {
        SoundOn.SetActive(false);
        SoundOff.SetActive(true);
        //SoundMusicBool = false;
    }

    public void SoundOff_Fuction()
    {
        SoundOn.SetActive(true);
        SoundOff.SetActive(false);
        //SoundMusicBool = true;
    }
}
