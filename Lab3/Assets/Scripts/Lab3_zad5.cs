using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3_zad5 : MonoBehaviour
{
    public GameObject Cube;
    List<Vector3> cubes;

    void Start()
    {
        cubes = new List<Vector3>();
        for(int i = 0; i < 10; i++)
        {
            Vector3 position;
            do
            {
                position = new Vector3(Random.Range(-10, 10), 0.5f, Random.Range(-10, 10));
            }
            while (isCubeInPosition(position));
            cubes.Add(position);
            Instantiate(Cube, position, Quaternion.identity);
        }
    }

    bool isCubeInPosition(Vector3 position)
    {
        foreach(Vector3 cube in cubes)
        {
            if (cube.x == position.x && position.z == cube.z)
            {
                return true;
            }
        }
        return false;
    }

    void Update()
    {
        
    }
}