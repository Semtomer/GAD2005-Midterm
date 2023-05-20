using UnityEngine;

public class Tetromino
{
    public TetrominoType Type { get; set; }
    public int[,] ShapeData { get; set; }
    public Color Color { get; set; }
    public int RotationAngle { get; set; }
}