
//It facilitates the creation and later modification of Tetromino Generator services.

using UnityEngine;

public interface ITetrominoGenerator
{
    Tetromino[] GenerateRandomTetrominoes(int count, GameObject[] tetrominoShapeList); //count -> represents how many will be created
}