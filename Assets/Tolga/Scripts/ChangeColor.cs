
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    Tetromino[] tetrominoes;
    private TetrominoInstantiater tetrominoInstantiater;

    private void Start()
    {
        tetrominoInstantiater = GameObject.FindWithTag("Canvas").GetComponent<TetrominoInstantiater>();
        tetrominoes = tetrominoInstantiater.tetrominoes;

        for (int i = 0; i < tetrominoes.Length; i++)
        {
            if (transform.parent.tag == tetrominoes[i].Tag) //
            {
                GetComponent<Image>().color = tetrominoes[i].Color;
            }
        }
    }
}
