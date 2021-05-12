using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiallogueManager : MonoBehaviour
{
    public GameObject dBox;
    public Text dText;
    public bool dialogActive;
    public string[] dialogLine;
    public int currentLine = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.F)) && dialogActive)
        {
            //dBox.SetActive(false);
            //dialogActive = false;
            currentLine++;
        }
        if (currentLine >= dialogLine.Length)
         {
            dBox.SetActive(false);
            dialogActive = false;
            
            currentLine = 0;
         }

        dText.text = dialogLine[currentLine];
    }

    public void ShowBox(string dialgue)
    {
        dialogActive = true;
        dBox.SetActive(true);
        dText.text = dialgue;
    }

    public void ShowDialog()
    {
        dialogActive = true;
        dBox.SetActive(true);
    }
}
