
using System.Collections.Generic;
using UnityEngine;

public class ItemsSlotted : MonoBehaviour
{
    Collider2D _collider;
    List<GameObject> createdTetrominoes;

    void Start()
    {
        _collider = GetComponent<Collider2D>();

        createdTetrominoes = GameObject.Find("Canvas").GetComponent<GameController>().createdTetrominoes;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Draggable.releasedTetromino == true && Draggable.InArea == true)
        {
            _collider.enabled = false;
            transform.position = collision.transform.position;

            createdTetrominoes.Remove(transform.parent.gameObject);
        }
    }
}
