using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovement : MonoBehaviour
{
    [SerializeField] private float rotationRate = 1f;
    [SerializeField] private Transform target;

    void Update()
    {
        Vector3 myRight = transform.TransformDirection(Vector3.right);
        Vector3 toTarget = Vector3.Normalize(target.position - transform.position);
        float targetRelative = Vector3.Dot(myRight, toTarget);
        transform.Rotate(Vector3.up * rotationRate * targetRelative * Time.deltaTime, Space.Self);
    }
}
