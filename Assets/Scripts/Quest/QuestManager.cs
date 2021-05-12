using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public QuestObjects[] quests;
    public bool[] questsComleted;
    public DiallogueManager theDM;
    public string itemCollected;
    public string enemyKilled;
    // Start is called before the first frame update
    void Start()
    {
        questsComleted = new bool[quests.Length];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowQuestText(string questText)
    {
        theDM.dialogLine = new string[1];
        theDM.dialogLine[0] = questText;
        theDM.currentLine = 0;
        theDM.ShowDialog();
    }
}
