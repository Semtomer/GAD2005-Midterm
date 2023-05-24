
using System.Collections.Generic;
using UnityEngine;

public class ItemsSlotted : MonoBehaviour
{
    Collider2D _collider;

    List<GameObject> createdTetrominoes;
    TetrominoInstantiater tetrominoInstantiater;

    bool runOnce = true;

    void Start()
    {
        _collider = GetComponent<Collider2D>();

        tetrominoInstantiater = GameObject.Find("Canvas").GetComponent<TetrominoInstantiater>();
        createdTetrominoes = tetrominoInstantiater.createdTetrominoes;
    }
    // this code check the when we release the tile and is that in the slot area and not in a row when these alright make the normal tile positin equal to the slot position
    // note: slots is square gray box on the playground
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Slot")
        {
            if (Draggable.releasedTetromino == true && Draggable.InArea == true && Draggable.FilledSlot == false)
            {
                gameObject.tag = "Tiles";
                //_collider.enabled = false;
                transform.position = collision.transform.position;

                createdTetrominoes.Remove(transform.parent.gameObject);

                if (runOnce)
                {
                    SpecialButton.hasClickedButton = true;
                    AudioManager.audioSourceForActionSound.PlayOneShot(AudioManager.actionSound, .2f);
                    runOnce = false;
                }
            }
        }
        
    }
}
