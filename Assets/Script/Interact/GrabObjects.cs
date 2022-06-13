using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GrabObjects : MonoBehaviour
{
    [SerializeField]
    private Transform grabPoint;

    [SerializeField]
    private Transform rayPoint;
    [SerializeField]
    private float rayDistance;

    private GameObject grabbedObject;
    private int layerIndex;

    void Start()
    {
        layerIndex = LayerMask.NameToLayer("Objects");
    }

    void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(rayPoint.position, transform.right, rayDistance);

        if(hitInfo.collider != null && hitInfo.collider.gameObject.layer == layerIndex)
        {
            if (Input.GetKeyDown(KeyCode.Z) && grabbedObject == null)
            {

            }
            
            else if(Input.GetKeyDown(KeyCode.Z) && grabbedObject == null)
            {

            }
        }

        Debug.DrawRay(rayPoint.position, transform.right * rayDistance);
    }
}
