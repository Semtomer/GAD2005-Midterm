
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
