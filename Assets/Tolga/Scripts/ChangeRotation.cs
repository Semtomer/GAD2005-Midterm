
using System.Collections.Generic;
using UnityEngine;

public class ChangeRotation : MonoBehaviour
{
    List<GameObject> createdTetrominoes;
    private TetrominoInstantiater tetrominoInstantiater;

    private void Start()
    {      
        tetrominoInstantiater = GameObject.FindWithTag("InstantiaterParent").GetComponent<TetrominoInstantiater>();
    }

    //This method is run on the change rotation button.
    public void ChangeRotationCreatedTetrominoes()
    {
        //The list of created tetromino objects is accessed.
        createdTetrominoes = tetrominoInstantiater.createdTetrominoes;

        foreach (GameObject tetromino in createdTetrominoes)
        {
            //Adds 90 angles to the z-rotation of the tetromino objects whose rotation is to be changed.
            tetromino.GetComponent<RectTransform>().eulerAngles = new Vector3(0f, 0f, tetromino.GetComponent<RectTransform>().eulerAngles.z + 90);
        }

        //Limits the change rotation button to the count of successful actions to be made.
        SpecialButton.hasClickedButton = true;
        SpecialButton.countOfActionsForButtons = 4;

        //Plays the action sound.
        if (Start_Page.SoundMusicBool == true)
        {
            AudioManager.audioSourceForActionSound.PlayOneShot(AudioManager.actionSound, .2f);
        }
       
    } 
}
