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
        Vector2 inputVector = value.Get<Vector2>();
        playerVector = new Vector3(inputVector.x, 0, inputVector.y);  // y -> z로 매핑
    }

    private void FixedUpdate()
    {
        Vector3 move = playerVector.normalized * playerSpeed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + move);
    }

    public void Attack()
    {
        Debug.Log("플레이어 공격");

    }
}
