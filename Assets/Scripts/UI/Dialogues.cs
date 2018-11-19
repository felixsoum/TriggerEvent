using System.Collections.Generic;
using UnityEngine;

public enum LanguageCode
{
    EN,
    FR,
    ES
}

public class Dialogues : MonoBehaviour
{
    [SerializeField] LanguageCode languageCode;
    private static Dictionary<string, string> dialogueDictionary = new Dictionary<string, string>();

    private void Awake()
    {
        DialogueDao.DatabasePath = "URI=file:" + Application.dataPath + "/Databases/Dialogues.db";
        dialogueDictionary = DialogueDao.GetAll(languageCode.ToString().ToLower());
    }

    public static string Get(string name)
    {
        return dialogueDictionary[name];
    }
}
