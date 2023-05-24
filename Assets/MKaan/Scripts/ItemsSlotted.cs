
using System.Collections.Generic;
using UnityEngine;

public class ItemsSlotted : MonoBehaviour
{
    Collider2D _collider;

    List<GameObject> createdTetrominoes;
    GameController gameController;

    void Start()
    {
        _collider = GetComponent<Collider2D>();

        gameController = GameObject.Find("Canvas").GetComponent<GameController>();
        createdTetrominoes = gameController.createdTetrominoes;      
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Draggable.releasedTetromino == true && Draggable.InArea == true && Draggable.FilledSlot == false)
        {
            _collider.enabled = false;
            transform.position = collision.transform.position;

            createdTetrominoes.Remove(transform.parent.gameObject);

            SpecialButton.hasClickedButton = true;

            AudioManager.audioSourceForActionSound.PlayOneShot(AudioManager.actionSound, .2f);
        }
    }
}
