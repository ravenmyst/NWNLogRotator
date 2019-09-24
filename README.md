# NWNLogRotator
Transforms and parses any Neverwinter Nights chat log into beautiful HTML. Written in C# .NET. NWNLogRotator is both Enhanced Edition and 1.69 compatible.

# Configuration Examples
Important: Open Windows Explorer and enter %HOMEPATH%, and the last directory there is your _USER_.
  
| Configuration  | Example | Description |
| ------------- | ------------- | ------------- |
| Output Directory | C:\Users\\_USER_\Documents\Neverwinter Nights\logs\ | New logs stored in default Steam EE log directory |
| Output Directory | C:\Program Files (x86)\Neverwinter Nights\logs\ | New logs stored in default 1.69 log directory |
| Path to Log | C:\Users\\_USER_\Documents\Neverwinter Nights\logs\nwClientLog1.txt | Get log from Steam EE default log directory |
| Path to Log | C:\Program Files (x86)\Neverwinter Nights\logs\nwClientLog1.txt | Get log from 1.69 default log directory |

# Automation (How it works)
While open, NWNLogRotator will try to process new logs automatically based on the status of whether Neverwinter Nights is running. If your directories are configured to match with your Neverwinter Nights default log storage, it will process them automatically.

# Notes
1) This application may warn you that the publisher is not signed or verified, but if you click 'More Info' it will allow you to run anyways.
2) The parsing will not be accurate if obtained from a third-party server that alters the standard NWN logging.
3) Changing the theme is available by clicking the "NWNLogRotator" header.
4) Please report any bugs or post suggestions. 

# Releases
Download Latest <a href="https://github.com/ravenmyst/NWNLogRotator/releases">Here</a>.

# In Development
1) Allowing automatic modification of nwnplayer.ini file to Enable logging.
2) Folder picker, or detect NWN log directory button that rotates between known stores and finds them.
3) Detach parsing from UI thread.
4) Convert FileHandler to a class.
5) Add Http.Get to allow user to specify custom parsing off a list from a source like github.

# Parsed Neverwinter Night Log Example:
Right Click <a href="https://raw.githubusercontent.com/ravenmyst/NWN-Log-Rotator/master/output/NWNLogExample.html">This Text</a> then select "Save Link As" and it should save it as an HTML. It is viewable using any desktop or mobile browser!

# NWNLogRotator Screenshot
![Screenshot of NWNLogRotator would be here](https://raw.githubusercontent.com/ravenmyst/NWNLogRotator/master/app1.png)
