public class PriestTrigger : TriggerEvent
{
    protected override void OnPlayerTrigger(PlayerController playerController)
    {
        dialoguePanel.Show(Dialogues.Get("priest"));
        playerController.Heal(10);
    }
}
