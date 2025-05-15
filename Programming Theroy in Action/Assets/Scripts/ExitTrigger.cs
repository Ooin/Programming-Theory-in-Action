using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        Destroy(collision.gameObject);
        ExitController controller = GetComponentInParent<ExitController>();
        if (controller != null)
            controller.ScorePoint();
    }
}