using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //public FloatValue playerHeatl;
    //public BoolValue chestA;
    //public BoolValue chestB;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewGame()
    {
        //playerHeatl.RuntimeValue = playerHeatl.initialValue;
        //chestA.RuntimeValue = chestA.initialValue;
        //chestB.RuntimeValue = chestB.initialValue;
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitToDesktop()
    {
        Application.Quit();
    }
}
