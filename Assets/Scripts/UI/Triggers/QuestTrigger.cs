public class QuestTrigger : TriggerEvent
{
    protected override void OnPlayerTrigger(PlayerController playerController)
    {
        dialoguePanel.Show(Dialogues.Get("quest"));
    }
}
