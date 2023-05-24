
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TetrominoInstantiater : MonoBehaviour
{
    //It was created to hold the tetrominoes returned by the main method in the TetrominoGenerator class.
    [HideInInspector] public Tetromino[] tetrominoes;

    private ITetrominoGenerator tetrominoGenerator;

    //It is assigned as a parameter to a method in the TetrominoGenerator class.
    [SerializeField] GameObject[] tetrominoShapeList;

    //The Spawn List is the list of prefabs that hold the positions of the tetrominoes to be created. It has also been added to Inspector.
    [SerializeField] RectTransform[] spawnList;

    //To add instantiated tetromino objects to list.
    [HideInInspector] public List<GameObject> createdTetrominoes;

    private void Start()
    {
        //If the tetromino generator service changes, the interface helps us with this code. 
        tetrominoGenerator = new TetrominoGenerator();
        InstantiateTetrominoes();
    }

    private void Update()
    {
        //The count of tetrominoes in the scene decreases as you make a successful actions or tetrominoes are thrown into the garbage.
        //When it is 0, it creates new ones.
        if (createdTetrominoes.Count == 0)
        {
            InstantiateTetrominoes();
        }
    }

    //This is where the instantiation of tetrominoes onto the scene takes place.
    private void InstantiateTetrominoes()
    {
        tetrominoes = tetrominoGenerator.GenerateRandomTetrominoes(3, tetrominoShapeList);

        for (int i = 0; i < tetrominoes.Length; i++)
        {
            //I have defined the parameters to be used in Instantiate separately here for legibility.
            GameObject tetrominoShape = tetrominoes[i].Shape;
            Vector3 position = spawnList[i].anchoredPosition3D;
            Quaternion rotationZ = Quaternion.Euler(0, 0, tetrominoes[i].RotationAngle);

            //Here I make the instantiate under the canvas and tag the objects created for the ChangeColor class.
            createdTetrominoes.Add(Instantiate(tetrominoShape, position, rotationZ, transform));
            createdTetrominoes[i].tag = tetrominoes[i].Tag;
        }
    }
}

