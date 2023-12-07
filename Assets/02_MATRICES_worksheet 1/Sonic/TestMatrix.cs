using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMatrix : MonoBehaviour
{
    private HMatrix2D mat = new HMatrix2D();
    private HMatrix2D mat1;
    private HMatrix2D mat2;
    // Start is called before the first frame update
    void Start()
    {
        //mat1 = new HMatrix2D(1, 2, 1, 0, 2, 0, 2, 3, 4);
        //mat2 = new HMatrix2D(2, 5, 1, 6, 7, 1, 1, 8, 1);
        //mat = mat1 * mat2;
        mat.setIdentity();
        //mat.Print();
        
    }


}
