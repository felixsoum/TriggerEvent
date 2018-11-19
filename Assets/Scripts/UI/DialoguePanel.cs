using UnityEngine;
using UnityEngine.UI;

public class DialoguePanel : MonoBehaviour
{
    [SerializeField] Text dialogueText;
    
    private void Awake()
    {
        Hide();
    }

    public void Show(string text)
    {
        dialogueText.text = text;
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        dialogueText.text = "";
        gameObject.SetActive(false);
    }
}
