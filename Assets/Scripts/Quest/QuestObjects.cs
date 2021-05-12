using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestObjects : MonoBehaviour
{
    public int questNumber;
    public QuestManager questManager;
    public string starText;
    public string endText;

    public bool IsItemQuest;
    public string targetItem;

    public bool isEnemyQuest;
    public string targetEnemy;
    public int enemiesToKill;
    private int enemiesKillCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(IsItemQuest)
        {
            if(questManager.itemCollected == targetItem)
            {
                questManager.itemCollected = null;
                EndQuest();
            }
        }

        if (isEnemyQuest)
        {
            if(questManager.enemyKilled == targetEnemy)
            {
                questManager.enemyKilled = null;
                enemiesKillCount++;
            }

            if(enemiesKillCount >= enemiesToKill)
            {
                EndQuest();
            }
        }    
    }

    public void StartQuest()
    {
        questManager.ShowQuestText(starText);
    }

    public void EndQuest()
    {
        questManager.ShowQuestText(endText);
        questManager.questsComleted[questNumber] = true;
        gameObject.SetActive(false);
    }
}
