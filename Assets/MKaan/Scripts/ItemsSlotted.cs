
using UnityEngine;

public class ItemsSlotted : MonoBehaviour
{
    Collider2D _collider;

    void Start()
    {
        _collider = GetComponent<Collider2D>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Draggable.releasedTetromino == true && Draggable.InArea == true && Draggable.FilledSlot == false)
        {
            _collider.enabled = false;
            transform.position = collision.transform.position;
        }
    }
}
