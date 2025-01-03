using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private StateMachine StateMachine;
    private Rigidbody rb;
    
    
    public Vector3 playerVector;
    [SerializeField]
    private float playerSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMove(InputValue value)
    {
        playerVector = value.Get<Vector3>();
    }

    private void FixedUpdate()
    {
        Vector3 move = playerVector.normalized * playerSpeed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + move);
    }
}
