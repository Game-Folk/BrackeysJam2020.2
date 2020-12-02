using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 1f;
    
    [Header("Unity Setup Fields")]
    public Transform counterGroup;
    public string layerAboveCounter;
    public string layerBelowCounter;

    private static Vector3 target;
    private SpriteRenderer renderer;

    void Start()
    {
        target = transform.position;
        renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {   
        // Move
        float step =  speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, target, step);

        // Update sorting layer
        if(transform.position.y > counterGroup.position.y)
        {
            renderer.sortingLayerName = layerAboveCounter;
        }
        else
        {
            renderer.sortingLayerName = layerBelowCounter;
        }
    }

    public static void UpdateTarget(Vector3 t)
    {
        target = t;
    }
}
