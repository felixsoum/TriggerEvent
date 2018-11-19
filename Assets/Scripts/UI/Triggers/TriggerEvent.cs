using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TriggerEvent : MonoBehaviour
{
    protected DialoguePanel dialoguePanel;

    private void Awake()
    {
        dialoguePanel = GameObject.FindGameObjectWithTag("DialoguePanel").GetComponent<DialoguePanel>();
    }

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.CompareTag("Player"))
        {
            OnPlayerTrigger(collider2D.GetComponent<PlayerController>());
        }
    }

    private void OnTriggerExit2D(Collider2D collider2D)
    {
        if (collider2D.CompareTag("Player"))
        {
            dialoguePanel.Hide();
        }
    }

    protected abstract void OnPlayerTrigger(PlayerController playerController);
}
