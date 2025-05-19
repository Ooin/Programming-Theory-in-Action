namespace DefaultNamespace
{
    public class BouncerSpin : BouncerBase
    {
        protected override void OnContact(Ball ball)
        {
            ball.BounceToggleSize();
        }
    }
}