using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SecondScript : MonoBehaviour
{
    public float speed;
    int Result;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(addition(10, 100));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed, 1, 1);
    }
    int addition(int a, int b)
    {
        Result = a + b;
        return Result;
    }
}