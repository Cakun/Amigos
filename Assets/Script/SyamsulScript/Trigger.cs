using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class Trigger : MonoBehaviour
{
    public UnityEvent onEnter;

    public void OnTriggerEnter2D(Collider2D collider)
    {
        onEnter?.Invoke();
    }

}
