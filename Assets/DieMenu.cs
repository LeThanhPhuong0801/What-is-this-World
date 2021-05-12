using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DieMenu : MonoBehaviour
{
    public GameObject pausePanel;
    public bool usingPausePanel;
    public string mainMenu;
    public FloatValue playerHeal;
    public BoolValue chestA;
    public BoolValue chestB;

    // Start is called before the first frame update
    void Start()
    {
        pausePanel.SetActive(false);
        usingPausePanel = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHeal.RuntimeValue == 0)
        {
            ChangePause();
        }

    }

    public void ChangePause()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0f;
        usingPausePanel = true;
    }

    public void QuitToMain()
    {
        playerHeal.RuntimeValue = playerHeal.initialValue;
        chestA.RuntimeValue = chestA.initialValue;
        chestB.RuntimeValue = chestB.initialValue;
        SceneManager.LoadScene(mainMenu);
        Time.timeScale = 1f;
    }
}
