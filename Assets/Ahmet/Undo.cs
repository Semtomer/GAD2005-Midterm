using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Undo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void back()
    {
        // Load a GameObject
        GameObjectSaveLoad gameObjectSaveLoad = new GameObjectSaveLoad();
        GameObject loadedObject = gameObjectSaveLoad.LoadGameObject();
        if (loadedObject != null)
        {
            // Use the loaded GameObject
            // For example, you can enable it or modify its properties
            loadedObject.SetActive(true);
            // Get the transform component of the object to move
            Transform objectTransform = loadedObject.transform;

            // Move the object to the destination position
            objectTransform.position = new Vector2(1, 1);
            //Vector2 objectTransform = 
        }
        else
        {
            Debug.LogWarning("Failed to load the saved object.");
        }
        Debug.Log(""+ PlayerPrefs.GetString("SavedGameObject", ""));
    }
}
