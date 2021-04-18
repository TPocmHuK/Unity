using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCube : MonoBehaviour
{
    public GameObject[] _Cubes;
    private GameObject cube;

    void Start() 
    {
        int cube = Random.Range (0, 4);
        Instantiate(_Cubes[cube], transform.position, Quaternion.identity);
    }
    
    public void createCube()
    {
        Debug.Log("createCube");
        int cubeIndex = Random.Range (0, 4);
        cube = _Cubes[cubeIndex];
        Instantiate(cube, new Vector3(0, 0.3f, -7f), Quaternion.identity);
    }
    
}
