using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public List<int> numbers = new List<int>() {1, 2, 3, 4, 5, 6, 7};

    private void Start()
    {
        numbers.RemoveAt(0);
        numbers.Add(2);

        foreach (int numbers in numbers);
        {
            print(numbers);
        }
    }
}
