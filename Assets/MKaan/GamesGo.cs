using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamesGo : MonoBehaviour
{
    public GameObject[] birebeþ;
    public LayerMask mask;
    void Start()
    {

    }
    bool bir;
    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < birebeþ.Length; i++)
        {
            if (birebeþ[i].transform.position.x < 290 || birebeþ[i].transform.position.x > 1130 || birebeþ[i].transform.position.y < 125 || birebeþ[i].transform.position.y > 970)
            {
                
            }
        }
        
        
        
    }
}
