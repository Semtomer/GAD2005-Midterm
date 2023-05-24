
using System.Collections.Generic;
using UnityEngine;

public class TetrominoInstantiater : MonoBehaviour
{
    [HideInInspector] public Tetromino[] tetrominoes;

    private ITetrominoGenerator tetrominoGenerator;

    [SerializeField] public GameObject[] tetrominoShapeList;

    [SerializeField] public RectTransform[] spawnList;

    [HideInInspector] public List<GameObject> createdTetrominoes;

    private void Start()
    {
        //If the tetromino generator service changes, the interface helps us with this code. 
        tetrominoGenerator = new TetrominoGenerator();
        InstantiateTetrominoes();
    }

    private void Update()
    {
        //
        if (createdTetrominoes.Count == 0)
        {
            InstantiateTetrominoes();
        }
    }

    private void InstantiateTetrominoes()
    {
        tetrominoes = tetrominoGenerator.GenerateRandomTetrominoes(3, tetrominoShapeList);

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

