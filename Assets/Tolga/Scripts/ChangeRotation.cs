
using System.Collections.Generic;
using UnityEngine;

public class ChangeRotation : MonoBehaviour
{
    List<GameObject> createdTetrominoes;

    public void ChangeRotationCreatedTetrominoes()
    {
        createdTetrominoes = GameObject.Find("Canvas").GetComponent<GameController>().createdTetrominoes;

        for (int i = 0; i < createdTetrominoes.Count; i++) 
        {
            createdTetrominoes[i].GetComponent<RectTransform>().eulerAngles = new Vector3(0f, 0f, createdTetrominoes[i].GetComponent<RectTransform>().eulerAngles.z + 90);
        }       
    } 
}
