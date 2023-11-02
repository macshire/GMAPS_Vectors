using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool IsCaptain = true;
    public Player OtherPlayer;

    //float Magnitude(Vector3 vector)
    //{
    //    // Your code here
    //}

    //Vector3 Normalise(Vector3 vector)
    //{
    //    // Your code here
    //}

    float Dot(Vector3 vectorA, Vector3 vectorB)
    {
        return Vector3.Dot(vectorA, vectorB);
    }

    float AngleToPlayer()
    {
        //direction of player to captain
        Vector3 directionToOther = OtherPlayer.transform.position - transform.position;
        //arrow from captain to player
        DebugExtension.DebugArrow(transform.position, directionToOther, Color.black);
        //arrow from player to player foward direction
        DebugExtension.DebugArrow(transform.position, transform.forward * 4.0f, Color.blue);

        return 0;
    }

    void Update()
    {
        if (IsCaptain)
        {
            //set the vector3 to the position of the other player
            Vector3 direction = OtherPlayer.transform.position;
            float angle = Mathf.Atan2(direction.z, direction.x) * Mathf.Rad2Deg;
            Debug.Log(angle);

            AngleToPlayer();
        }
    }
}
