using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerExample : MonoBehaviour
{
    public float speed;
    public FixedJoystick variableJoystick;
    //public Rigidbody rb;

    public void Update()
    {
        Vector3 direction = variableJoystick.Direction;
       // rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
transform.position += direction
            * speed * Time.deltaTime;
    }
}