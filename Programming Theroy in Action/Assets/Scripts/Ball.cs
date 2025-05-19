using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;
using Random = UnityEngine.Random;

public class Ball : MonoBehaviour
{
    [SerializeField] SphereCollider sphereCollider;
    [SerializeField] Rigidbody rigidbody;
    private float _sizeToggle = 1.5f;
    private bool _isSmall = false;
    /*public void reduceBall()
    {
        transform.localScale -= new Vector3(amounreduced, amounreduced, amounreduced);
    }

    public void ()
    {
        
    }*/
    private void Start()
    {
        _sizeToggle = Random.Range(1.2f, 1.9f);
    }

    public void Bounce(Vector3 direction, float bounceStrength)
    {
        float limitedBounceStrength = Mathf.Max(bounceStrength, rigidbody.velocity.magnitude + 1);
        
        rigidbody.velocity = direction * limitedBounceStrength;
    }

    public void BounceToggleSize()
    {
        if (_isSmall)
        {
            transform.localScale *= _sizeToggle;
        }
        else
        {
            transform.localScale /= _sizeToggle;
        }
        
        _isSmall = !_isSmall;
    }
    
}



