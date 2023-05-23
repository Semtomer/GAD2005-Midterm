
using System.Collections.Generic;
using UnityEngine;

public class ChangeRotation : MonoBehaviour
{
    List<GameObject> createdTetrominoes;
    private GameController gameController;

    private void Start()
    {
        gameController = GameObject.Find("Canvas").GetComponent<GameController>();
    }

    public void ChangeRotationCreatedTetrominoes()
    {
        createdTetrominoes = gameController.createdTetrominoes;

        foreach (GameObject tetromino in createdTetrominoes)
        {
            tetromino.GetComponent<RectTransform>().eulerAngles = new Vector3(0f, 0f, tetromino.GetComponent<RectTransform>().eulerAngles.z + 90);
        }
    } 
}
