import moviepy.editor as mp
from pathlib import Path
from pytube import YouTube
from VideoDownloader import CreateFileInfo,remove_emoji
from pathvalidate import sanitize_filepath

#REQUIRES INSTALATION BEFORE DEPLOYMENT

""" from FileReader import * """


DownloadDir = Path("downloads")
DownloadCount = 0
Completed = 0 
Fail = 0 
Attemps = 1

def DownloadSong(link,download_location,tempId):

       print("LINK: "+link)
       yt = YouTube(link)
       print("Video Name: "+yt.title)
       fileName = download_location+tempId+".mp4"
   
       reg_filter = remove_emoji(download_location+sanitize_filepath(yt.title)+".mp3") #regex.sub(r'[^\w]', ' ',yt.title+".mp3")
       print("Clean File Name: "+reg_filter)
       fileInfo = fileName+".info"
       
       CreateFileInfo(yt,fileInfo,fileName)

       print("Temporal FileName: "+fileName)
       '''download_location = download_location + fileName'''
       print("Download Location: "+download_location)
       print("Download Started")
       
       
       filter = yt.streams.filter(file_extension='mp4').get_lowest_resolution().download(output_path=download_location, filename=fileName, filename_prefix="",
              skip_existing=True, timeout=10000, max_retries=10)

       print("Comverting to mp3")
       print("File located: "+str(Path(fileName).is_file))

       mp3 = mp.VideoFileClip(fileName)
     
       print("Saiving Song As: "+reg_filter)
       
       mp3.audio.write_audiofile(Path(reg_filter))     

          
          

          
          
     