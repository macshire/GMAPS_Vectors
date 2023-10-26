using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioHVector2D : MonoBehaviour
{
    public Transform planet;
    public float force = 5f;
    public float gravityStrength = 5f;

    private HVector2D gravityDir, gravityNorm;
    private HVector2D moveDir;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        //direction from object to centre of planet
        gravityDir = new HVector2D(planet.position - transform.position);
        gravityDir.Normalize();
        moveDir = new HVector2D(gravityDir.y, -gravityDir.x);
        moveDir.Normalize();

        rb.AddForce(gravityDir.ToUnityVector3() * gravityStrength);
        rb.AddForce(-moveDir.ToUnityVector3() * force);

        //calculate angle between gravitydir and movedir in radian to degrees
        //create a perpendicular line to differentiate between positive and negative angle for rotation
        float angle = Mathf.Rad2Deg * gravityDir.FindAngle(new HVector2D(0, -1));
        

        //rotates object to specified angle
        rb.MoveRotation(Quaternion.Euler(0, 0, angle));

        DebugExtension.DebugArrow(transform.position, gravityDir.ToUnityVector3() * gravityStrength, Color.red);
        DebugExtension.DebugArrow(transform.position, -moveDir.ToUnityVector3(), Color.blue);

    }
}
