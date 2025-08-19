using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    private float velocity = 0.05f;
    private float angleA = 10f;
    public KeyCode keyUp = KeyCode.UpArrow;
    public KeyCode keyDown = KeyCode.DownArrow;
    public KeyCode keyLeft = KeyCode.LeftArrow;
    public KeyCode keyright = KeyCode.RightArrow;
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
        if (Input.GetKey(rotateLeft))
        {
            Quaternion.ro
        }
        GetComponent<SpriteRenderer>().color = Random.ColorHSV(); //cambiar color ramdom 
    }
}
