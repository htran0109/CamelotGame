import sys

def interpretText():
    separatorChar = "%"
    interpretedStrings = []
    print ("Args:" , str(sys.argv))
    if len(sys.argv) < 2:
        print ("A script file argument is expected")
        return [""];
    fileName = sys.argv[1]
    fileObj = open(fileName, "r")
    changedFileObj = open("Converted" + fileName, "w+")

    scriptLine = ""
    name = "nullBoy"
    emotion = "neutral"
    position = "2" #center stage
    background = "plain"
    nextLine = fileObj.readline()
    while nextLine != "":
        lineStrings = nextLine.split(separatorChar)
        if(len(lineStrings) == 5):
            background = lineStrings[4]
        if(len(lineStrings) >= 4):
            position = lineStrings[3]
        if(len(lineStrings) >= 3) :
            emotion = lineStrings[2]
        if(len(lineStrings) >= 2) :
            name = lineStrings[1]
        if(len(lineStrings) >= 1) :
            scriptLine = lineStrings[0]

        writeStringSeq = (scriptLine, name, emotion, position, background)
        writeString = separatorChar.join(writeStringSeq)
        changedFileObj.write(writeString)
        nextLine = fileObj.readline()
        #Parse next line and figure stuff out
        # limiter1 = -1
        # limiter2 = -1
        # limiter3 = -1
        # limiter4 = -1
        # limiter1 = nextLine.find(separatorChar)
        # if limiter1 != -1:
        #     scriptLine = nextLine[:limiter1]
        #     limiter2 = nextLine.find(separatorChar, limiter1)
        # if limiter2 != -1:
        #     name = nextLine[limiter1:limiter2]
        #     limiter3 = nextLine.find(separatorChar, limiter2)
        # else:
        #     name = nextLine[limiter1:]
        # if limiter3 != -1:
        #     emotion = nextLine[limiter2:limiter3]
        #     limiter4 = nextLine.find(separatorChar, limiter3)
        # else:
        #     emotion = nextLine[limiter2:]
        # if limiter4 != -1:
        #     position = nextLine[limiter3:limiter4]
        #     background = nextLine[]
    fileObj.close()
    changedFileObj.close()

    return interpretedStrings;

interpretText();
