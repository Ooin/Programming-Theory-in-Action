using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BouncerBase : MonoBehaviour
{ 
    protected abstract void OnContact(Ball ball);

    protected void OnCollisionEnter(Collision other)
    {
        Ball ball = other.gameObject.GetComponentInParent<Ball>();
        if (ball != null)
        {
            OnContact(ball);
        }
    }
}