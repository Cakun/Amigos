using UnityEngine;
using UnityEngine.Events;


public class Interaction : MonoBehaviour
{
    //DetectionPoint
    public Transform detectionPoint;
    //Detection radius
    private const float detectionRadius = 0.2f;
    //Detection Layer
    public LayerMask detectionLayer;
    public UnityEvent onDialogue;


    void Update()
    {
        if (DetectObject())
        {
            if (InteractInput())
            {
                onDialogue.Invoke();
            }
        }
    }

    bool InteractInput()
    {
        return Input.GetKeyDown(KeyCode.Z);
    }

    bool DetectObject()
    {
        return Physics2D.OverlapCircle(detectionPoint.position, detectionRadius, detectionLayer);

    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(detectionPoint.position, detectionRadius);
    }
}
