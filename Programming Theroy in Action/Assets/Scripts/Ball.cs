using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class Ball : MonoBehaviour
{
    public void OnDestroy()
    {
        Debug.Log("Ball destroyed");
        Destroy(this);
    }
}