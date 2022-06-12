using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractionSystem : MonoBehaviour
{
    //DetectionPoint
    public Transform detectionPoint;
    //Detection radius
    private const float detectionRadius = 0.2f;
    //Detection Layer
    public LayerMask detectionLayer;

    public string loadMap;

    void Update()
    {
        if (DetectObject())
        {
            if (InteractInput())
            {
                SceneManager.LoadScene(loadMap);
            }
        }
    }

    bool InteractInput()
    {
        return Input.GetKeyDown(KeyCode.E);
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
