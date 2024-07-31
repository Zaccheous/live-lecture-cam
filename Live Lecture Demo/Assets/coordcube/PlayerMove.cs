using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // A movement value 
    [SerializeField] private float moveSpeed = 1f;
    // A direction value
    private Vector3 moveDirection = Vector3.right; // same as new Vector3(1.0f, 0.5f, 0.0f);
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Make my object move every frame, according to speed and direction
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.Self);
        
    }

    void OnTriggerEnter(Collider collider)
    {
        moveDirection = Vector3.forward;
        Debug.Log("Trigger Collision Detected");
    }
}
