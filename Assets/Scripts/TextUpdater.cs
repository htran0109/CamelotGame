using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextUpdater : MonoBehaviour {

    public static GameObject GUIObject;
    public static Text textToEdit;
    public static Image UIBackground;
    private static TextUpdater updateSingleton;
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
		
	}

    /**
     * 
     */

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
        textToEdit.text = newText;
    }
}
