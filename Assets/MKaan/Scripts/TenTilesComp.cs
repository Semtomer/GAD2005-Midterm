
using System.Collections.Generic;
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
        //this is check the missing Object on the list
        for (var i = Tiles.Count - 1; i > -1; i--)
        {
            if (Tiles[i] == null)
                Tiles.RemoveAt(i);
        }

        //this is check when we release the Tiles and not release them in a row and when the line become 10 destroy all tiles on than line
        if(Draggable.releasedTetromino == true && Draggable.FilledSlot == false)
        {
            if(Tiles.Count >= 10)
            {
                for (var i = Tiles.Count - 1; i > -1; i--)
                {
                    Destroy(Tiles[i]);
                }

                if (Start_Page.SoundMusicBool == true)
                {
                    AudioManager.audioSourceForWinSound.PlayOneShot(AudioManager.winSound, .2f);
                }     
            } 
        }

    }

    // These triggers check the individual Tiles one by one and add them to the list 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Tiles")
        {
            Tiles.Add(collision.gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Tiles")
        {
            Tiles.Remove(collision.gameObject);
        }
    }
}
