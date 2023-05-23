
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [HideInInspector] public static bool releasedTetromino = false;
    bool releasedtetromino2 = false;

    GameObject ItemSlotsCollider;

    Draggable draggable;

    Vector2 currentPosition;

    bool firstPick;
    public static bool InArea;
    bool InArea2;

    public static bool FilledSlot;
    bool FilledSlot2;

    public GameObject LeftBottomCornerBound;
    public GameObject RightTopCornerBound;

    //List<GameObject> createdTetrominoes;
    void Start()
    {
        ItemSlotsCollider = GameObject.FindWithTag("Canvas");

        draggable = GetComponent<Draggable>();

        currentPosition = transform.position;

        //createdTetrominoes = GameObject.Find("Canvas").GetComponent<GameController>().createdTetrominoes;
    }

    void ManuelDetector()
    {
        if(LeftBottomCornerBound == null || RightTopCornerBound == null)
            return;

        if (LeftBottomCornerBound.transform.position.x > 170 
            && LeftBottomCornerBound.transform.position.x < 1015 
            && LeftBottomCornerBound.transform.position.y > 120 
            && LeftBottomCornerBound.transform.position.y < 960 
            && RightTopCornerBound.transform.position.x > 170 
            && RightTopCornerBound.transform.position.x < 1015 
            && RightTopCornerBound.transform.position.y > 120 
            && RightTopCornerBound.transform.position.y < 960)
        {
            InArea = true;
            InArea2 = true;
        }
        else
        {
            InArea = false;
            InArea2 = false;
        }
            
    }
    void Update()
    {
        if(firstPick == true)
            ManuelDetector();

        if(releasedtetromino2 == true && InArea2 == true && FilledSlot == false)
        {
            draggable.enabled = false;
        }

        if (InArea2 == false && FilledSlot2 == true)
        {
            FilledSlot = false;
            FilledSlot2 = false;
        }
    }
  
    public void OnBeginDrag(PointerEventData eventData)
    {
        firstPick = true;
        releasedTetromino = false;
        releasedtetromino2 = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public static bool MakeItDisactive;
    public void OnEndDrag(PointerEventData eventData)
    {
        releasedTetromino = true;
        releasedtetromino2 = true;
        firstPick = false;

        if(InArea == false || FilledSlot == true)
        {

            Destroy(gameObject,0.1f);
            Instantiate(gameObject, currentPosition, Quaternion.identity,ItemSlotsCollider.transform);
        }
        
            
        if(InArea == true)
        {
            gameObject.tag = "Filled";
        }
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Filled")
        {
            FilledSlot = true;
            FilledSlot2 = true;
        }
        if (collision.gameObject.tag == "Destroy")
        {
            Destroy(gameObject,0.25f);
            //createdTetrominoes.Remove(transform.parent.gameObject);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Filled")
        {
            FilledSlot = false;
            FilledSlot2 = false;
        }
    }

}
