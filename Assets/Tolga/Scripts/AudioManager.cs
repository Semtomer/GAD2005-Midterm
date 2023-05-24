
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] public static AudioSource audioSourceForActionSound,
                                               audioSourceForWinSound,
                                               audioSourceForDeniedSound,
                                               audioSourceForLoseSound;

    [SerializeField] public static AudioClip actionSound,
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
