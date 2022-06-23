using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectObject : MonoBehaviour
{
    public Animator _animator;
    private void OnTriggerEnter2D(Collider2D poster)
    {   
        if(poster.gameObject.name == "Player")
        {
            _animator.SetBool("isGlow", true);
        }
    }

    private void OnTriggerExit2D(Collider2D poster)
    {
        if (poster.gameObject.name == "Player")
        {
            _animator.SetBool("isGlow",false);
        }
    }
}
