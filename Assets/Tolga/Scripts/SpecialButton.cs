
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpecialButton : MonoBehaviour 
{
    public List<Button> buttons;
    public static int countOfActionsForButtons = 0;
    public static bool hasClickedButton = false;

    GameObject garbage;
    [SerializeField] public Sprite garbageSprite;

    private void Start()
    {
        garbage = GameObject.FindWithTag("Destroy");
    }

    private void Update()
    {
        Debug.Log(countOfActionsForButtons);
        
        if (countOfActionsForButtons == 0) 
        {
            foreach (Button button in buttons)
            {
                button.interactable = true;
                
                garbage.GetComponent<BoxCollider2D>().enabled = true;
                garbage.GetComponent<Image>().sprite = null;
            }
        }
        else
        {
            foreach (Button button in buttons)
            {
                button.interactable = false;
                
                garbage.GetComponent<BoxCollider2D>().enabled = false;
                garbage.GetComponent<Image>().sprite = garbageSprite;
            }
        }

        if (countOfActionsForButtons != 0 && hasClickedButton == true)
        {
            countOfActionsForButtons--;
            hasClickedButton = false;
        }
    }
}