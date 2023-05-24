
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    Tetromino[] tetrominoes;
    private GameController gameController;

    private void Start()
    {
        gameController = GameObject.FindWithTag("Canvas").GetComponent<GameController>();
        tetrominoes = gameController.tetrominoes;

        for (int i = 0; i < tetrominoes.Length; i++)
        {
            if (transform.parent.tag == TetrominoGenerator.tags[i])
            {
                GetComponent<Image>().color = tetrominoes[i].Color;
            }
        }
    }
}
