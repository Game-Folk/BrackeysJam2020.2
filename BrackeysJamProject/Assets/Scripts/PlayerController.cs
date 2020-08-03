using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 1f;
    private static Vector3 target;

    void Start()
    {
        target = transform.position;
    }

    // Update is called once per frame
    void Update()
    {   
        float step =  speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, target, step);
    }

    public static void UpdateTarget(Vector3 t)
    {
        target = t;
    }
}
