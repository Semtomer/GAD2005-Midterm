using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [HideInInspector] public Tetromino[] tetrominoes;

    private ITetrominoGenerator tetrominoGenerator;

    [SerializeField] public GameObject[] tetrominoShapeList;

    [SerializeField] public RectTransform[] spawnList;

    [HideInInspector] public List<GameObject> createdTetrominoes;

    private void Start()
    {
        tetrominoGenerator = new TetrominoGenerator();
        InstantiateTetromino();
    }

    private void Update()
    {
        if (createdTetrominoes.Count == 0)
        {
            Debug.Log(createdTetrominoes.Count);
            InstantiateTetromino();
        }
        else 
        {
            Debug.Log(createdTetrominoes.Count);
        }
    }

    public void InstantiateTetromino()
    {
        tetrominoes = tetrominoGenerator.GenerateRandomTetrominoes(3, tetrominoShapeList);


        foreach (Tetromino tetromino in tetrominoes)
        {
            Debug.Log("Tetromino Type: " + tetromino.Shape.name);
            Debug.Log("Tetromino Color: " + tetromino.Color);
            Debug.Log("Tetromino Rotation Angle: " + tetromino.RotationAngle);
        }

        for (int i = 0; i < tetrominoes.Length; i++)
        {
            GameObject tetrominoShape = tetrominoes[i].Shape;
            Vector3 position = spawnList[i].anchoredPosition3D;
            Quaternion rotationZ = Quaternion.Euler(0, 0, tetrominoes[i].RotationAngle);

            createdTetrominoes.Add(Instantiate(tetrominoShape, position, rotationZ, transform));
            createdTetrominoes[i].tag = tetrominoes[i].Tag;
        }
    }
}

