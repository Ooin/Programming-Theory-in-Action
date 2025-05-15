using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    [SerializeField]private GameObject ball;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            clickPosition.z = -0.77f;
            clickPosition.y = 9.0f;
            Instantiate(ball, clickPosition, Quaternion.identity);

        }
    }
}