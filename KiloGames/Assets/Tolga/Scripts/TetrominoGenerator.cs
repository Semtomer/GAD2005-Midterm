
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
            //Tags for the ChangeColor class.

            tetrominoes[i] = tetromino;
        }

        return tetrominoes;
    }

    //Returns the index of one of the random tetromino types to select the shape of the tetromino object to be created.
    //The order in the inspector is the same as in the tetromino type.
    private int GetRandomTetrominoTypeIndex()
    {
        TetrominoType[] tetrominoTypes = (TetrominoType[])System.Enum.GetValues(typeof(TetrominoType));
        return Random.Range(0, tetrominoTypes.Length);
    }

    //Returns a random color for the Tetromino object.
    private Color GetRandomColor()
    {
        Color[] colors = new Color[]
        {
            Color.red, Color.green, Color.blue, Color.yellow
        };

        return colors[Random.Range(0, colors.Length)];
    }

    //Returns a random rotation for the Tetromino object.
    private int GetRandomRotationAngle()
    {
        int[] rotationAngles = new int[] { 0, 90, 180, 270 };
        return rotationAngles[Random.Range(0, rotationAngles.Length)];
    }
}