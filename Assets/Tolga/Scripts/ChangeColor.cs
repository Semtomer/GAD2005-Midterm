
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    Tetromino[] tetrominoes;

    private void Start()
    {
        tetrominoes = GameObject.Find("Canvas").GetComponent<GameController>().tetrominoes;

        if (transform.parent.tag == TetrominoGenerator.tags[0])
        {
            GetComponent<Image>().color = tetrominoes[0].Color;
        }
        else if (transform.parent.tag == TetrominoGenerator.tags[1])
        {
            GetComponent<Image>().color = tetrominoes[1].Color;
        }
        else if (transform.parent.tag == TetrominoGenerator.tags[2])
        {
            GetComponent<Image>().color = tetrominoes[2].Color;
        }
    }
}
