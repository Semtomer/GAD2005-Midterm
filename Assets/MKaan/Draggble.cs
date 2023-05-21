using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class Draggble : MonoBehaviour,IBeginDragHandler,IDragHandler,IEndDragHandler
{
    [HideInInspector] public static bool released = false;
    public Collider2D itemslotscollider;
    Draggble dragi;
    Vector2 curretpos;
    void Start()
    {
        itemslotscollider = GetComponentInChildren<Collider2D>();
        dragi = GetComponent<Draggble>();
        curretpos = transform.position;
    }

    // Update is called once per frame

    public GameObject Sýnýr1;
    public GameObject Sýnýr2;
    public static bool InArea;
    void manuelalgýlayýcý()
    {
        if(Sýnýr1 == null || Sýnýr2 == null)
        {
            return;
        } 
        if (Sýnýr1.transform.position.x > 290 && Sýnýr1.transform.position.x < 1130 && Sýnýr1.transform.position.y > 125 && Sýnýr1.transform.position.y < 970 &&
            Sýnýr2.transform.position.x > 290 && Sýnýr2.transform.position.x < 1130 && Sýnýr2.transform.position.y > 125 && Sýnýr2.transform.position.y < 970)
        {
            InArea = true;
        }
        else
        {
            InArea = false;
        }
    }
    float time;
    void Update()
    {
        if(ilkalým == true)
        {
            manuelalgýlayýcý();
        }
        if (itemslotscollider.enabled == false)
        {
            dragi.enabled = false;
        }
    }
    bool ilkalým;
    public void OnBeginDrag(PointerEventData eventData)
    {
        print("begindrag");
        ilkalým = true;
        released = false;
    }
    public void OnDrag(PointerEventData eventData)
    {
        print("drag");
        transform.position = Input.mousePosition;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        print("enddrag");
        released = true;
        ilkalým = false;
        if(InArea == false)
        {
            transform.position = curretpos;
        }
    }
    
}
