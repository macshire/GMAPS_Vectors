using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mario : MonoBehaviour
{
    public Transform planet;
    public float force = 5f;
    public float gravityStrength = 5f;

    private Vector3 gravityDir, gravityNorm;
    private Vector3 moveDir;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        //calculate direction from object position to centre of planet
        gravityDir = planet.position - transform.position;
        //changes move direction based on gravity
        moveDir = new Vector3(gravityDir.y, -gravityDir.x, 0f);
        moveDir = moveDir.normalized * -1f;

        //applying force to object
        rb.AddForce(moveDir * force);

        gravityNorm = gravityDir.normalized;
        //adds gravity force to object 
        rb.AddForce(gravityNorm * gravityStrength);

        //finding signed angle between vector pointing down and forward
        float angle = Vector3.SignedAngle(Vector3.right,
            moveDir, Vector3.forward);

        //rotates object to specified angle
        rb.MoveRotation(Quaternion.Euler(0, 0, angle));

        DebugExtension.DebugArrow(transform.position,
            gravityNorm * gravityStrength, Color.red);

        DebugExtension.DebugArrow(transform.position,
            moveDir, Color.blue);
    }
}


