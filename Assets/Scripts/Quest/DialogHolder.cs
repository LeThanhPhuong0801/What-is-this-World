using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogHolder : MonoBehaviour
{
    public string dialog;
    private DiallogueManager diallogueManager;

    public string[] dialogLines;
    // Start is called before the first frame update
    void Start()
    {
        diallogueManager = FindObjectOfType<DiallogueManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if(Input.GetKeyUp(KeyCode.F))
            {
                //diallogueManager.ShowBox(dialog);

                if(!diallogueManager.dialogActive)
                {
                    diallogueManager.dialogLine = dialogLines;
                    diallogueManager.currentLine = 0;
                    diallogueManager.ShowDialog();
                }
            }
        }
    }
}
