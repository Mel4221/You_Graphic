from shelve import Shelf
from traceback import print_tb
from unittest import result
import shutil
import os 
from SongDownloader import DownloadSong
from VideoDownloader import DownloadVideo
from Searcher import FindSong, GetDetails
 
'''
MP3
MP4_720P
MP4_1080P
'''
def CheckArgs(list):
    print(list) 
    print("Action: "+list[0])
    type = list[0]
    link = list[1]
    download_location = list[2]
    tempId=list[3]
    if type=="MP3":
        print("Downloading song: ")
        DownloadSong(link,download_location,tempId)
        return
    if type=="MP4_720P":
        print("Downloading Video at 720P")
        DownloadVideo(link,"",download_location,tempId)
        return
    if type=="MP4_1080P":
        print("Downloading Video at 720P")
        DownloadVideo(link,"1080",download_location,tempId)
        return
            

