using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.wKey.isPressed){
            transform.Translate(
                new Vector3(0,0,1) * moveSpeed * Time.deltaTime
                );
        }
    }
}
