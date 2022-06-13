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

    public string sceneName;
    public Animator transitionAnim;

    void Update()
    {
        if (DetectObject())
        {
            if (InteractInput())
            {
                StartCoroutine(LoadScene());
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

    IEnumerator LoadScene()
    {
        transitionAnim.SetTrigger("isChange");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(sceneName);
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(detectionPoint.position, detectionRadius);
    }
}
