public class FireTrigger : TriggerEvent
{
    protected override void OnPlayerTrigger(PlayerController playerController)
    {
        playerController.Damage(10);
    }
}
