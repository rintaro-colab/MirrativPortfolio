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
        Vector3 moveDirection = new Vector3(0,0,0); 

        if (Keyboard.current.wKey.isPressed){
               moveDirection =  moveDirection + new Vector3(0,0,1) ;
        }

        if (Keyboard.current.sKey.isPressed){
               moveDirection = moveDirection + new Vector3(0,0,-1) ;
        }

        if (Keyboard.current.aKey.isPressed){
              moveDirection = moveDirection + new Vector3(-1,0,0);
        }

        if (Keyboard.current.dKey.isPressed){
              moveDirection = moveDirection +  new Vector3(1,0,0) ;
        }   

        transform.Translate(
             moveDirection.normalized * moveSpeed * Time.deltaTime
        );
    }
}
