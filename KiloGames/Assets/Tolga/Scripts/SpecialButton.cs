
//This class is added to the Canvas.
//Limits the mechanics of two buttons and a garbage can to the count of successful actions.

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpecialButton : MonoBehaviour 
{
    //Here the necessary variables for buttons and constraints are defined.
    public List<Button> buttons;
    public static int countOfActionsForButtons = 0;
    public static bool hasClickedButton = false;

    GameObject garbage;
    [SerializeField] Sprite garbageSpriteOpen;
    [SerializeField] Sprite garbageSpriteClosed;

    private void Start()
    {
        //Reaches the garbage object.
        garbage = GameObject.FindWithTag("Destroy");
    }

    private void Update()
    {
        //If the count of successful actions to be made is 0, the buttons and the garbage can become active. Otherwise they are inactive.
        if (countOfActionsForButtons == 0) 
        {
            foreach (Button button in buttons)
            {
                button.interactable = true;
                
                garbage.GetComponent<BoxCollider2D>().enabled = true;
                garbage.GetComponent<Image>().sprite = garbageSpriteOpen;
            }
        }
        else
        {
            foreach (Button button in buttons)
            {
                button.interactable = false;
                
                garbage.GetComponent<BoxCollider2D>().enabled = false;
                garbage.GetComponent<Image>().sprite = garbageSpriteClosed;
            }
        }

        //As successful actions are made, the count of successful actions required is reduced.
        if (countOfActionsForButtons != 0 && hasClickedButton == true)
        {
            countOfActionsForButtons--;
            hasClickedButton = false;
        }
    }
}