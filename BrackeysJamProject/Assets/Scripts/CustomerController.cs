using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerController : MonoBehaviour
{
    public float speed = 1f;
    private Transform target;

    void Update()
    {
        float step =  speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, GetTarget().position, step);
    }

    public void SetTarget(Transform transform)
    {
        target = transform;
    }

    public Transform GetTarget()
    {
        return target;
    }
}
