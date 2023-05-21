using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Start_Page : MonoBehaviour
{
    public GameObject SoundOn,SoundOff;
    bool SoundMusicBool = true;

    void Start()
    {
        SoundOn.SetActive(true);
        SoundOff.SetActive(false);
    }

    void Update()
    {
        
    }

    public void Play_Button_Fuction()
    {
        SceneManager.LoadScene("SampleScene");
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
