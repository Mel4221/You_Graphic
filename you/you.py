import sys
from pathlib import Path
import os 
from VideoDownloader import DownloadVideo
from DownloadWithArgs import CheckArgs
 
def main():
            args = sys.argv[1:]
            if len(args) > 0:
                print("passing arguments")
                CheckArgs(args)
                return 0
            else:
                print("no arguments were provided")
                return 1

if __name__ == '__main__':
    main()
 
 
