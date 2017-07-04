using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class TranscriptReader{

    public string[] sceneStrings;
    public static TranscriptReader readerSingleton;
    public int currLineIndex;
    
    /**
     * retVals: Next line in the scene
     * error retVal: null if scene not found or end of scene found
     **/
    public static string getNextLine(string sceneName)
    {
        //use singleton strategy to implement methods
        if(readerSingleton == null)
        {
            readerSingleton = new TranscriptReader();
        }
        //shorter name for readability
        TranscriptReader rs = readerSingleton;
        //if the file has not yet been loaded, load in strings
        if(rs.sceneStrings == null)
        {
            rs.sceneStrings = rs.loadNewFile("sceneName.scene");
            if(rs.sceneStrings == null)
            {
                Debug.LogError("Scene Not Found");
                return null;
            }
            rs.currLineIndex = 0;
        }
        //then, load in the next string
        string nextString = rs.sceneStrings[rs.currLineIndex];
        rs.currLineIndex++;
        //use the string 'endScene' to signify that no line is going to be used
        if(nextString.Equals("endScene"))
        {
            rs.sceneStrings = null;
            return null;
        }
        else
        {
            return nextString;
        }
    }

    /**
     *  Loads in all the lines from a .scene file.
     *  
     *  File format is many strings separated by new lines, ending with
     *  one string on it's own line, 'endScene'
     **/
    private string[] loadNewFile(string filename)
    {
        try
        {
            //initialize fileReading, keep reading until all strings are read in
            List<string> lines = new List<string>();
            string nextLine;
            StreamReader fileReader = new StreamReader(filename);
            while ((nextLine = fileReader.ReadLine()) != null)
            {
                lines.Add(nextLine);
            }
            return lines.ToArray();
        }
        catch
        {
            Debug.LogError("Error opening File");
            return null;
        }
    }
}
