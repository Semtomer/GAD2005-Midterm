
using UnityEngine;

public class GameObjectSaveLoad : MonoBehaviour
{
    private const string GameObjectKey = "SavedGameObject";

    // Save a GameObject to PlayerPrefs
    public void SaveGameObject(GameObject gameObjectToSave)
    {
        // Get the unique identifier of the GameObject
        string gameObjectID = gameObjectToSave.GetInstanceID().ToString();

        // Save the GameObject ID to PlayerPrefs
        PlayerPrefs.SetString(GameObjectKey, gameObjectID);
        PlayerPrefs.Save();
    }

    // Load a GameObject from PlayerPrefs
    public GameObject LoadGameObject()
    {
        // Retrieve the GameObject ID from PlayerPrefs
        string gameObjectID = PlayerPrefs.GetString(GameObjectKey, "");

        if (string.IsNullOrEmpty(gameObjectID))
        {
            Debug.LogWarning("No saved GameObject found.");
            return null;
        }

        // Find the GameObject based on its ID
        GameObject loadedGameObject = GameObject.Find(gameObjectID);

        if (loadedGameObject == null)
        {
            Debug.LogWarning("Failed to find the saved GameObject with ID: " + gameObjectID);
            return null;
        }

        return loadedGameObject;
    }
}

