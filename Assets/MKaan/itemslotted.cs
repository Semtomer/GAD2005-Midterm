using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemslotted : MonoBehaviour
{
    // Start is called before the first frame update
    Collider2D coli;
    void Start()
    {
        coli = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Draggble.released == true && Draggble.InArea == true)
        {
            coli.enabled = false;
            transform.position = collision.transform.position;
        }
    }
}
