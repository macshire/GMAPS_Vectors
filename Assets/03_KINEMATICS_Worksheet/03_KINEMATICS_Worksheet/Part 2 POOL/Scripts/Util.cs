using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Util
{
    public static float FindDistance(HVector2D p1, HVector2D p2)
    {
        //HVector2D a = new HVector2D(8f, 5f);
        //HVector2D b = new HVector2D(1f, 3f);
        //float distance = Util.FindDistance(a, b);
        //return Mathf.Sqrt((p2.x - p1.x)*2 + (p2.y - p2.y)*2);
        float posX = p2.x - p1.x;
        float posY = p2.y - p1.y;
        return Mathf.Sqrt(posX * posX + posY * posY);
    }
}

