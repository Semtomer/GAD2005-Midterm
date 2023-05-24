
using UnityEngine;

public class TetrominoGenerator : ITetrominoGenerator
{
    //The tags of the tetrominoes that will be created are located here.
    string[] tags = new string[] { "first", "second", "third"};

    //Creates Tetromino objects and assigns properties to the created objects with the other methods. Returns the generated Tetromino objects.
    public Tetromino[] GenerateRandomTetrominoes(int count, GameObject[] tetrominoShapeList)
    {
        Tetromino[] tetrominoes = new Tetromino[count];

        for (int i = 0; i < count; i++)
        {
            Tetromino tetromino = new Tetromino();

            tetromino.Shape = tetrominoShapeList[GetRandomTetrominoTypeIndex()];
            tetromino.RotationAngle = GetRandomRotationAngle();
            tetromino.Color = GetRandomColor();
            tetromino.Tag = tags[i];
            
            tetrominoes[i] = tetromino;
        }

        return tetrominoes;
    }

    private int GetRandomTetrominoTypeIndex()
    {
        TetrominoType[] tetrominoTypes = (TetrominoType[])System.Enum.GetValues(typeof(TetrominoType));
        return Random.Range(0, tetrominoTypes.Length);
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