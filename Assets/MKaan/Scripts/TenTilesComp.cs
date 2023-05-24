using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Unity.Burst.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

public class TenTilesComp : MonoBehaviour
{
    Collider2D _collider;
    void Start()
    {
        _collider = GetComponent<Collider2D>();
    }

    public List<GameObject> Tiles = new List<GameObject>();
    void Update()
    {
        for (var i = Tiles.Count - 1; i > -1; i--)
        {
            if (Tiles[i] == null)
                Tiles.RemoveAt(i);
        }
        if(Draggable.releasedTetromino == true && Draggable.FilledSlot == false)
        {
            if(Tiles.Count >= 10)
            {
                for (var i = Tiles.Count - 1; i > -1; i--)
                {
                    Destroy(Tiles[i]);
                }
            }
            
           
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Tiles")
        {
            Tiles.Add(collision.gameObject);
            print("eklendi");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Tiles")
        {
            Tiles.Remove(collision.gameObject);
            print("çýkarýldý");
        }
    }
}
