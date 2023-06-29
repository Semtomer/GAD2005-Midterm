
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_Page : MonoBehaviour
{
    public GameObject SoundOn,SoundOff;
    public static bool SoundMusicBool = true;

    void Start()
    {
        new ScoreUpdater().ResetScore();

        SoundOn.SetActive(true);
        SoundOff.SetActive(false);
    }

    public void Play_Button_Fuction()
    {
        SceneManager.LoadScene(1);
    }

    public void SoundOn_Fuction()
    {
        SoundOn.SetActive(false);
        SoundOff.SetActive(true);
        SoundMusicBool = false;
    }

    public void SoundOff_Fuction()
    {
        SoundOn.SetActive(true);
        SoundOff.SetActive(false);
        SoundMusicBool = true;
    }
}
