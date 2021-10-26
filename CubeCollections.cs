using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeCollections : MonoBehaviour
{
    [SerializeField] private List<GameObject> cubes;
    [SerializeField] private Text inputText;

    public void DeleteCube()
    {
        Destroy(cubes[int.Parse(inputText.text)]);
        cubes.RemoveAt(int.Parse(inputText.text));
    }

    public void PrintCube()
    {
        print(cubes[int.Parse(inputText.text)]);
    }
}
