import moviepy.editor as mp
import regex
from pathlib import Path
import os
 
from pytube import YouTube
 
from Searcher import *

import emoji




Attemps = 0 
"""
def CreateFileInfo(yt,fileInfo,fileName):
          a = open(fileInfo,"a")
          a.write("KEY=VIDEO_FILE;\nVALUE="+fileName+";\n")
          a.write("KEY=VIDEO_TITLE;\nVALUE="+yt.title+";\n")
          a.write("KEY=VIDEO_LENGTH;\nVALUE="+str(yt.length)+";\n")
          a.write("KEY=VIDEO_DESCRIPTION;\nVALUE="+str(yt.description)+";\n")
          a.write("KEY=VIDEO_THUMBNAIL_URL;\nVALUE="+str(yt.thumbnail_url)+";\n")
          a.close()

"""
def CreateFileInfo(yt,fileInfo,fileName):
          a = open(fileInfo,"a",encoding="utf-8")
          a.write(fileName+"\n")
          a.write(yt.title+"\n")
          a.write(str(yt.length)+"\n")
          a.write(str(yt.description)+"\n")
          a.write(str(yt.thumbnail_url)+"\n")
          a.close()


def remove_emoji(string):
    s = emoji.replace_emoji(string, replace="")
    if s.__contains__("/"):
            s = s.replace("/","")
    if s.__contains__("\""):
            s = s.replace("\\")
    return s 
    #return emoji.replace_emoji(string, replace='')

def DownloadVideo(videoLink,videoQuality,download_location,tempId):
          global Attemps
          #Clear()
          print("Downloading Video: "+videoLink)
          
            #videoQuality = "1080p"
          yt = YouTube(videoLink)
          fileName = download_location+regex.sub(r'[^\w]', ' ',yt.title)+".mp4"
          fileInfo = download_location+tempId+".mp4.info"
          CreateFileInfo(yt,fileInfo,fileName)
       
          if videoQuality=="":
                  videoQuality = "720"
  
          videoQuality = videoQuality+"p"
          print("Downloading... "+yt.title+" Attemp: "+str(Attemps)+" Video Quality: "+videoQuality) 
          #filter = yt.streams.filter(resolution=videoQuality)#.first().download(output_path="downloads/videos/", filename=yt.title+".mp4", filename_prefix="",skip_existing=True, timeout=10000, max_retries=10)
          try:

                      filter = yt.streams.filter(resolution=videoQuality).first().download(output_path=download_location, filename=fileName, filename_prefix="",skip_existing=True, timeout=300, max_retries=10)
                      print("The Video has been downloaded Sucessfully "+yt.title)          
                      print("File Location: "+fileName)

          #.get_lowest_resolution().download(output_path="downloads/videos/", filename="video.mp4", filename_prefix="",skip_existing=True, timeout=10000, max_retries=10)
          except:
                    #global Attemps
                    Attemps = Attemps + 1
                    if Attemps == 1:
                              print("Attempting again due to an error...")
                              DownloadVideo(videoLink,"",download_location)
                              return
                    if Attemps == 2:
                              print("Download Quality Set to Default '720p' Due to TOO MANY ATTEMPS")
                              print("Please try a lower Video Quality if the video keeps Attempting...")
                              DownloadVideo(videoLink,"720",download_location)
                              return
                    if Attemps == 3:
                              print("Download Quality Set to Default '480p' Due to TOO MANY ATTEMPS")
                              print("Please try a lower Video Quality if the video keeps Attempting...")
                              DownloadVideo(videoLink,"480",download_location)
                              return
                    if Attemps == 4:
                              print("Download Quality Set to Default '360p' Due to TOO MANY ATTEMPS")
                              print("Please try a lower Video Quality if the video keeps Attempting...")
                              DownloadVideo(videoLink,"360",download_location)
                              return
                    if Attemps == 5:
                              print("Download Quality Set to Default '144p' Due to TOO MANY ATTEMPS")
                              print("Please try a lower Video Quality if the video keeps Attempting...")
                              DownloadVideo(videoLink,"144",download_location)
                              return
          return
                    
          #<Stream: itag="22" mime_type="video/mp4" res="720p" fps="30fps" vcodec="avc1.64001F" acodec="mp4a.40.2" progressive="True" type="video">,
          #().download(output_path="downloads/video/", filename="video", filename_prefix="",skip_existing=True, timeout=10000, max_retries=10)
      