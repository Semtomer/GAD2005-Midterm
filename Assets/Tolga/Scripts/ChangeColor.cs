
//This class has been added to the "item" prefab that created tetromino structures in the assets.

using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    Tetromino[] tetrominoes;
    private TetrominoInstantiater tetrominoInstantiater;

    private void Start()
    {
        //Reaching the created tetromino list.
        tetrominoInstantiater = GameObject.FindWithTag("Canvas").GetComponent<TetrominoInstantiater>();
        tetrominoes = tetrominoInstantiater.tetrominoes;

        for (int i = 0; i < tetrominoes.Length; i++)
        {
            //It changes the color of the "item" according to the tag of the parent of the "item" prefab that is one of the tetrominoes.
            //In other words, all "items" under the same parent are in the same color.
            if (transform.parent.tag == tetrominoes[i].Tag) 
            {
                GetComponent<Image>().color = tetrominoes[i].Color;
            }
        }
    }
}
