
using UnityEngine;

public interface ITetrominoGenerator
{
    Tetromino[] GenerateRandomTetrominoes(int count, GameObject[] tetrominoShapeList);
}