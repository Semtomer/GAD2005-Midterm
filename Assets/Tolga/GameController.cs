using UnityEngine;

public class GameController : MonoBehaviour
{
    private readonly ITetrominoGenerator tetrominoGenerator;

    private void Start()
    {
        ITetrominoGenerator tetrominoGenerator = new TetrominoGenerator();
        Tetromino[] tetrominoes = tetrominoGenerator.GenerateRandomTetrominoes(3);

        foreach (Tetromino tetromino in tetrominoes)
        {
            Debug.Log("Tetromino Type: " + tetromino.Type);
            Debug.Log("Tetromino Color: " + tetromino.Color);
            Debug.Log("Tetromino Rotation Angle: " + tetromino.RotationAngle);
        }
    }
}

