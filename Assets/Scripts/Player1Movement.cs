using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour
{
    private float velocity = 0.05f;
    private float angleA = 10f;
    public KeyCode keyUp = KeyCode.W;
    public KeyCode keyDown = KeyCode.S;
    public KeyCode keyLeft = KeyCode.A;
    public KeyCode keyright = KeyCode.D;
    public KeyCode rotateLeft = KeyCode.Q;
    public KeyCode rotateRight = KeyCode.E;

    private void Update()
    {
        if (Input.GetKey(keyUp))
        {
            transform.position = transform.position + new Vector3(0, velocity, 0);
        }
        if (Input.GetKey(keyDown))
        {
            transform.position = transform.position + new Vector3(0, -velocity, 0);
        }
        if (Input.GetKey(keyLeft))
        {
            transform.position = transform.position + new Vector3(-velocity, 0, 0);
        }
        if (Input.GetKey(keyright))
        {
            transform.position = transform.position + new Vector3(velocity, 0, 0);
        }

    }
}
