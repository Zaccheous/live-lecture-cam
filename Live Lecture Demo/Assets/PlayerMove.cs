using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1f;
    private Vector3 moveDirection = Vector3.right;
    
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.Self);
    }

    void OnTriggerEnter(Collider collider)
    {
        moveDirection = Vector3.forward;
        Debug.Log("Trigger collision detected");
    }
}
