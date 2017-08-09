#!/usr/bin/python

import sys


def interpretText:
    separatorChar = "%"
    interpretedStrings = []
    print 'Args:', str(sys.argv)
    if len(sys.argv) < 2:
        print 'A script file argument is expected'
        return [""]
        fileName = sys.argv[1]
        fileObj = open(fileName, "text")
        changedFileObj = open(fileName + "Script", "text")
        name = "nullBoy"
        scriptLine = ""
        emotion = "neutral"
        position = "2" #center stage
        background = "plain"
        while nextLine = fileObj.readline != "":


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


        return interpretedStrings
