using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamesGo : MonoBehaviour
{
    public GameObject[] birebe�;
    public LayerMask mask;
    void Start()
    {

    }
    bool bir;
    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < birebe�.Length; i++)
        {
            if (birebe�[i].transform.position.x < 290 || birebe�[i].transform.position.x > 1130 || birebe�[i].transform.position.y < 125 || birebe�[i].transform.position.y > 970)
            {
                
            }
        }
        
        
        
    }
}
