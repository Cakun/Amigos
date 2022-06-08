using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimTitle : MonoBehaviour
{
    [SerializeField]
    private float delayAnim;

    private Animator anim;
    private float timeOut;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        timeOut += Time.deltaTime;

        if(timeOut > delayAnim)
        {
            anim.SetBool("isShake", true);
        }
    }
}
