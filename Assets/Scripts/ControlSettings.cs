using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControlSettings : MonoBehaviour
{
    public GameObject PauseButton, PausePopUp, GameOverPopUp, SoundOn, SoundOff;
    public Animator PausePopUpAnim, GameOverPopUpAnim;

    void Start()
    {
        FirstSettingsLoad();
    }

    void FirstSettingsLoad()
    {
        PauseButton.SetActive(true);
        PausePopUp.SetActive(false);
        GameOverPopUp.SetActive(false);

        if (Start_Page.SoundMusicBool == true)
        {
            //tolga ya sorulacak
        }
        else if (Start_Page.SoundMusicBool == false)
        {
            //tolga ya sorulacak
        }
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

    public void Reload_Game_Fuction()
    {
        SceneManager.LoadScene("TemporaryScene");
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

    public void Play_Game_Fuction()
    {
        PausePopUpAnim.SetTrigger("ClosePopUpAnim");
        StartCoroutine("WaitPopUpAnim");
    }

    IEnumerator WaitPopUpAnim()
    {
        yield return new WaitForSeconds(3);
        PauseButton.SetActive(true);
        PausePopUp.SetActive(false);
    }
}
