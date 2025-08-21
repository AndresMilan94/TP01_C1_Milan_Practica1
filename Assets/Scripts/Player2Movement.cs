using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    private float velocity = 0.05f;
    private float angleRotation = 10f;
    public KeyCode keyUp = KeyCode.UpArrow;
    public KeyCode keyDown = KeyCode.DownArrow;
    public KeyCode keyLeft = KeyCode.LeftArrow;
    public KeyCode keyRight = KeyCode.RightArrow;
    public KeyCode rotateLeft = KeyCode.Keypad1;
    public KeyCode rotateRight = KeyCode.Keypad3;
    public KeyCode changeColor = KeyCode.Keypad0;

    SpriteRenderer spriteRenderer; 
    private void Awake()
    {
        if (spriteRenderer == null)
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
            Debug.Log("El spriteRenderer era nulo");
        }
    }

    private void Update()
    {
        if (Input.GetKey(keyUp))
        {
            MoveUp(keyUp);
        }
        if (Input.GetKey(keyDown))
        {
            MoveDown(keyDown);
        }
        if (Input.GetKey(keyLeft))
        {
            MoveLeft(keyLeft);
        }
        if (Input.GetKey(keyRight))
        {
            MoveRight(keyRight);
        }
        if (Input.GetKeyDown(rotateLeft))
        {
            RotationL(rotateLeft);
        }
        if (Input.GetKeyDown(rotateRight))
        {
            RotationR(rotateRight);
        }
        if (Input.GetKeyUp(changeColor))
        {
            ChangeRandomColor(changeColor);
        }

    }
    private void MoveUp (KeyCode key)
    {
            transform.position = transform.position + new Vector3(0, velocity, 0);
    }
    private void MoveDown(KeyCode key)
    {
        transform.position = transform.position + new Vector3(0, -velocity, 0);
    }
    private void MoveLeft(KeyCode key)
    {
        transform.position = transform.position + new Vector3(-velocity, 0, 0);
    }
    private void MoveRight(KeyCode key)
    {
        transform.position = transform.position + new Vector3(velocity, 0, 0);
    }
    private void RotationL(KeyCode key)
    {
        transform.Rotate(new Vector3(0, 0, angleRotation));
    }
    private void RotationR(KeyCode key)
    {
        transform.Rotate (new Vector3(0, 0, -angleRotation));
    }
    private void ChangeRandomColor(KeyCode key)
    {
        spriteRenderer.color = Random.ColorHSV();
    }
}
