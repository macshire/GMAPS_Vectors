using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMatrix : MonoBehaviour
{
    private HMatrix2D mat = new HMatrix2D();
    // Start is called before the first frame update
    void Start()
    {
        mat.setIdentity();
        mat.Print();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
