
using UnityEngine;

public class TetrominoGenerator : ITetrominoGenerator
{
    public Tetromino[] GenerateRandomTetrominoes(int count)
    {
        Tetromino[] tetrominoes = new Tetromino[count];

        for (int i = 0; i < count; i++)
        {                      
            Tetromino tetromino = new Tetromino();

            tetromino.Type = GetRandomTetrominoType();
            tetromino.RotationAngle = GetRandomRotationAngle();
            tetromino.ShapeData = TetrominoShapeData.getShapeDataForDegrees(tetromino.Type, tetromino.RotationAngle);
            tetromino.Color = GetRandomColor();
            
            tetrominoes[i] = tetromino;
        }

        return tetrominoes;
    }

    private TetrominoType GetRandomTetrominoType()
    {
        TetrominoType[] tetrominoTypes = (TetrominoType[])System.Enum.GetValues(typeof(TetrominoType));
        return tetrominoTypes[Random.Range(0, tetrominoTypes.Length)];
    }

    private Color GetRandomColor()
    {
        Color[] colors = new Color[]
        {
            Color.red, Color.green, Color.blue, Color.yellow
        };

        return colors[Random.Range(0, colors.Length)];
    }

    private int GetRandomRotationAngle()
    {
        int[] rotationAngles = new int[] { 0, 90, 180, 270 };
        return rotationAngles[Random.Range(0, rotationAngles.Length)];
    }
}