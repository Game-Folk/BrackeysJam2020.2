using UnityEngine;

public class TargetUpdater : MonoBehaviour
{
    void OnMouseDown()
    {
        PlayerController.UpdateTarget(transform.position);
    }
}
