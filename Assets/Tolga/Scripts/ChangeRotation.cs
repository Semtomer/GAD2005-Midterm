
using System.Collections.Generic;
using UnityEngine;

public class ChangeRotation : MonoBehaviour
{
    List<GameObject> createdTetrominoes;
    private TetrominoInstantiater tetrominoInstantiater;

    private void Start()
    {      
        tetrominoInstantiater = GameObject.Find("Canvas").GetComponent<TetrominoInstantiater>();
    }

    public void ChangeRotationCreatedTetrominoes()
    {
        createdTetrominoes = tetrominoInstantiater.createdTetrominoes;

        foreach (GameObject tetromino in createdTetrominoes)
        {
            tetromino.GetComponent<RectTransform>().eulerAngles = new Vector3(0f, 0f, tetromino.GetComponent<RectTransform>().eulerAngles.z + 90);
        }

        SpecialButton.hasClickedButton = true;
        SpecialButton.countOfActionsForButtons = 4;

        AudioManager.audioSourceForActionSound.PlayOneShot(AudioManager.actionSound, .2f);
    } 
}
