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

    public GameObject S�n�r1;
    public GameObject S�n�r2;
    public static bool InArea;
    void manuelalg�lay�c�()
    {
        if(S�n�r1 == null || S�n�r2 == null)
        {
            return;
        } 
        if (S�n�r1.transform.position.x > 290 && S�n�r1.transform.position.x < 1130 && S�n�r1.transform.position.y > 125 && S�n�r1.transform.position.y < 970 &&
            S�n�r2.transform.position.x > 290 && S�n�r2.transform.position.x < 1130 && S�n�r2.transform.position.y > 125 && S�n�r2.transform.position.y < 970)
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
        if(ilkal�m == true)
        {
            manuelalg�lay�c�();
        }
        if (itemslotscollider.enabled == false)
        {
            dragi.enabled = false;
        }
    }
    bool ilkal�m;
    public void OnBeginDrag(PointerEventData eventData)
    {
        print("begindrag");
        ilkal�m = true;
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
        ilkal�m = false;
        if(InArea == false)
        {
            transform.position = curretpos;
        }
    }
    
}
