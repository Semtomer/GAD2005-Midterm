
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [HideInInspector] public static bool releasedTetromino = false;
    bool releasedtetromino2 = false;

    public GameObject ItemSlotsCollider;

    Draggable draggable;

    Vector2 currentPosition;

    bool firstPick;
    public static bool InArea;
    bool InArea2;

    public GameObject LeftBottomCornerBound;
    public GameObject RightTopCornerBound;

    void Start()
    {
        ItemSlotsCollider = GameObject.FindWithTag("Canvas");
        draggable = GetComponent<Draggable>();
        currentPosition = transform.position;
    }

    void ManuelDetector()
    {
        if(LeftBottomCornerBound == null || RightTopCornerBound == null)
            return;

        if (LeftBottomCornerBound.transform.position.x > 290 
            && LeftBottomCornerBound.transform.position.x < 1130 
            && LeftBottomCornerBound.transform.position.y > 125 
            && LeftBottomCornerBound.transform.position.y < 970 
            && RightTopCornerBound.transform.position.x > 290 
            && RightTopCornerBound.transform.position.x < 1130 
            && RightTopCornerBound.transform.position.y > 125 
            && RightTopCornerBound.transform.position.y < 970)
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
        //print(FilledSlot);

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
            //MakeItDisactive = true;
            //transform.position = currentPosition;
            Destroy(gameObject,0.1f);
            Instantiate(gameObject, currentPosition, Quaternion.identity,ItemSlotsCollider.transform);
        }//
        
            
        //
        if(InArea == true)
        {
            gameObject.tag = "Filled";
        }
        //
    }
    public static bool FilledSlot;//
    bool FilledSlot2;

    private void OnTriggerStay2D(Collider2D collision)//
    {
        if (collision.gameObject.tag == "Filled")
        {
            FilledSlot = true;
            FilledSlot2 = true;
        }
        if (collision.gameObject.tag == "Destroy")
        {
            Destroy(gameObject,0.25f);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)//
    {
        if (collision.gameObject.tag == "Filled")
        {
            FilledSlot = false;
            FilledSlot2 = false;
        }
    }//

}
