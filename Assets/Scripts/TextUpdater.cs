using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextUpdater : MonoBehaviour {

    public static GameObject GUIObject;
    public static Text textToEdit;
    public static Image UIBackground;
    private static TextUpdater updateSingleton;
    private static bool textScrolling;
    private static string currText;
    private static int currLoadedIndex;
	// Use this for initialization


    /*when the new singleton is created, update all the fields to have access to them
     *in this class
     */
	void Start () {
        GUIObject = GameObject.FindGameObjectWithTag("MainGUI");
        //assign text and image fields of the gui
        textToEdit = this.gameObject.transform.GetChild(0).
                        GetChild(1).gameObject.GetComponent<Text>();
        UIBackground = this.gameObject.transform.GetChild(0).
                            GetChild(0).gameObject.GetComponent<Image>();
        TextUpdater.updateText("Hello World");
    }
	
	// Update is called once per frame
	void Update () {
        checkKeys();
        slowUpdateText();
	}

    /**
     * Simple tester for the TranscriptReader class
     */
     void checkKeys()
    {
        if (Input.GetButtonDown("Fire1") && textScrolling == false)
        {
            updateText(TranscriptReader.getNextLine("testScene"));
            textScrolling = true;
            
        }
        else if (Input.GetButtonDown("Fire1") && textScrolling == true)
        {
            fastLoadText();
            
        }
    }

    public static void slowUpdateText()
    {
        if (textScrolling == true)
        {
            slowUpdateIterate();
        }
    }

    public static void slowUpdateIterate()
    {
        if(currLoadedIndex > currText.Length)
        {
            textScrolling = false;
        }
        else
        {
            textToEdit.text = currText.Substring(0, currLoadedIndex);
            currLoadedIndex++;
        }
    }

    /**
     * Using the existing text box underneath the GUI element, update the text
     * (later will want to make the text scroll in one character by character
     **/
    public static void updateText(string newText)
    {
        /*if(updateSingleton == null)
        {
            updateSingleton = new TextUpdater();
        }*/
        //temp call to immediately show text
        //textToEdit.text = newText;
        currText = newText;
        currLoadedIndex = 0;
    }

    public static void fastLoadText()
    {
        textToEdit.text = currText;
        textScrolling = false;
    }
}

