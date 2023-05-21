
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [HideInInspector] public static bool releasedTetromino = false;

    Collider2D ItemSlotsCollider;

    Draggable draggable;

    Vector2 currentPosition;

    bool firstPick;
    public static bool InArea;

    public GameObject LeftBottomCornerBound;
    public GameObject RightTopCornerBound;

    void Start()
    {
        ItemSlotsCollider = GetComponentInChildren<Collider2D>();
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
        }
        else
            InArea = false;
    }

    void Update()
    {
        if(firstPick == true)
            ManuelDetector();
        if (ItemSlotsCollider.enabled == false)
            draggable.enabled = false;
    }
  
    public void OnBeginDrag(PointerEventData eventData)
    {
        firstPick = true;
        releasedTetromino = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        releasedTetromino = true;
        firstPick = false;

        if(InArea == false)
            transform.position = currentPosition;
    }
    
}
