
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [HideInInspector] public static bool releasedTetromino = false;
    bool releasedtetromino2 = false;

    GameObject ItemSlotsCollider;

    Draggable draggable;

    Vector2 currentPosition;
    Quaternion currentRotation;

    bool firstPick;
    public static bool InArea;
    bool InArea2;

    public static bool FilledSlot;
    bool FilledSlot2;

    public GameObject LeftBottomCornerBound;
    public GameObject RightTopCornerBound;

    List<GameObject> createdTetrominoes;

    Collider2D[] _colliderList;

    void Start()
    {
        ItemSlotsCollider = GameObject.FindWithTag("Canvas");

        draggable = GetComponent<Draggable>();
        //when it is respawn in check the last position and spawn it same
        currentPosition = transform.position;

        createdTetrominoes = GameObject.Find("Canvas").GetComponent<TetrominoInstantiater>().createdTetrominoes;

        _colliderList = GetComponents<Collider2D>();

        foreach (var collider in _colliderList) 
        {
            collider.enabled = false; 
        }
    }
    //this method check the player Area
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

        //whne player put the tile on slot that tile is unable to drag again
        if(releasedtetromino2 == true && InArea2 == true && FilledSlot == false)
        {
            draggable.enabled = false;
        }

        if (InArea2 == false && FilledSlot2 == true)
        {
            FilledSlot = false;
            FilledSlot2 = false;
        }
        //when it is respawn in check the last rotation and spawn it same
        currentRotation = transform.rotation;         
    }
    //this event supply when player start to dragging
    public void OnBeginDrag(PointerEventData eventData)
    {
        foreach (var collider in _colliderList)
        {
            collider.enabled = true;
        }

        firstPick = true;
        releasedTetromino = false;
        releasedtetromino2 = false;
    }
    //this event supply when player continue to dragging
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    //this event supply when player release to dragging
    public void OnEndDrag(PointerEventData eventData)
    {
        releasedTetromino = true;
        releasedtetromino2 = true;
        firstPick = false;
        //check is this in area or not in a row with Tiles 
        if(InArea == false || FilledSlot == true)
        {
            Destroy(gameObject,0.1f);
            createdTetrominoes.Remove(gameObject);
            createdTetrominoes.Add(Instantiate(gameObject, currentPosition, currentRotation, ItemSlotsCollider.transform));
            AudioManager.audioSourceForDeniedSound.PlayOneShot(AudioManager.deniedSound, .2f);
        }
        //check is this in area and not in a row with Tiles           
        if (InArea == true && FilledSlot == false)
        {
            gameObject.tag = "Filled";          
        }     
    }

    //deal of here is when trigger detect the Filled tagged object it say that Slot is filled so that is the mean of "FilledSlot"
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Filled")
        {
            FilledSlot = true;
            FilledSlot2 = true;
        }
        //this is the trash box when drag on it
        if (collision.gameObject.tag == "Destroy") 
        {
            Destroy(gameObject,0.25f);
            createdTetrominoes.Remove(gameObject);

            SpecialButton.hasClickedButton = true;
            SpecialButton.countOfActionsForButtons = 4;

            AudioManager.audioSourceForActionSound.PlayOneShot(AudioManager.actionSound, .2f);
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
