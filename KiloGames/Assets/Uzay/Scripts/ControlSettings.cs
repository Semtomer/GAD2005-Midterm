using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlSettings : MonoBehaviour
{
    public GameObject PauseButton, PausePopUp, GameOverPopUp, SoundOn, SoundOff;
    public Animator PausePopUpAnim, GameOverPopUpAnim;
    public AudioSource GamePlaySound, LostSound;

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
            SoundOff_Fuction();
        }
        else if (Start_Page.SoundMusicBool == false)
        {
            SoundOn_Fuction();
        }
    }

    public void Turn_Start_Page_Fuction()
    {
        SceneManager.LoadScene(0);

        new ScoreUpdater().ResetScore();
    }

    public void Pause_Button_Fuction()
    {
        PauseButton.SetActive(false);
        PausePopUp.SetActive(true);    
    }

    public void Reload_Game_Fuction()
    {
        SceneManager.LoadScene(1);

        new ScoreUpdater().ResetScore();
    }

    public void SoundOn_Fuction()
    {
        SoundOn.SetActive(false);
        SoundOff.SetActive(true);
        Start_Page.SoundMusicBool = false;
        GamePlaySound.Stop();
    }

    public void SoundOff_Fuction()
    {
        SoundOn.SetActive(true);
        SoundOff.SetActive(false);
        Start_Page.SoundMusicBool = true;
        GamePlaySound.Play();
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

    public void Game_Over_Fuction()
    {
        GameOverPopUp.SetActive(true);
        GamePlaySound.Stop();
        LostSound.Play();
    }
}
