using UnityEngine;

namespace DefaultNamespace
{
    public class BouncerRetainer : BouncerBase
    {
        
        [SerializeField] private float bounceStrength = 1;
        protected override void OnContact(Ball ball)
        {
            Vector3  direction = (ball.transform.position - transform.position).normalized;
            ball.Bounce(direction, bounceStrength);
        }
    }
}