
//Sounds to be added to the mechanics are defined here. The play of the sounds is within their mechanical code.

using UnityEngine;

public class AudioManager : MonoBehaviour
{   
    public static AudioSource audioSourceForActionSound,
                              audioSourceForWinSound,
                              audioSourceForDeniedSound,
                              audioSourceForLoseSound;

    public static AudioClip actionSound,
                            winSound,
                            deniedSound,
                            loseSound;

    private void Start()
    {
        audioSourceForActionSound = GameObject.FindWithTag("ActionSound").GetComponent<AudioSource>();
        actionSound = audioSourceForActionSound.clip;

        audioSourceForWinSound = GameObject.FindWithTag("WinSound").GetComponent<AudioSource>();
        winSound = audioSourceForWinSound.clip;

        audioSourceForDeniedSound = GameObject.FindWithTag("DeniedSound").GetComponent<AudioSource>();
        deniedSound = audioSourceForDeniedSound.clip;

        audioSourceForLoseSound = GameObject.FindWithTag("LoseSound").GetComponent<AudioSource>();
        loseSound = audioSourceForLoseSound.clip;
    }
}
