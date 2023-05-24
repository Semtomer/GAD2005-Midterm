using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileBlockDestroy : MonoBehaviour
{
    public Collider2D[] _colliderList;
    public GameObject[] Items;
    void Start()
    {
        _colliderList = GetComponents<Collider2D>();
    }
    //This code check when the Tiles destroyed also destroy their Collider to prevent bugs which detect that slot is empty or not
    void Update()
    {
        for (int i = 0; i < _colliderList.Length; i++)
        {
            if (Items[i] == null)
            {
                Destroy(_colliderList[i]);
            }
        }
    }
}
