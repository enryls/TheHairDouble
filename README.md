# The Hair Double
## Abstract
“The Hair Double” is an application that allows users to scan a 3D model of their face which is then used to
create a 3D avatar that resemble the user itself. Through the avatar it’s possible to try and change different
hair styles from a predefined set of existing hair styles and, when the user chooses one, he or she can see
the final result on the avatar. An alternative use of the application is to try the hair style directly on a live
video of the user.
The points of strength of this application are the possibility for the user of having a realistic view on him or
herself with the desired hair style, the feeling, while viewing the final result, of standing in front of a mirror,
as the avatar moves in a specular way with the user and the ease of use of the application.
Promo Video on https://www.youtube.com/watch?v=2AViNNzndAI .
## Goal
The goal of “The Hair Double” is to be an instrument for users to have a realistic and detailed preview of a
desired hairstyle on themselves, which is not achievable with a picture modified in Photoshop.
## Implementation
### Hardware
The video output for the application should be a medium/large screen (at least 24” diagonal length) for an
optimal result.
To guarantee better performances, the application should be used on a PC with these minimum requirements:
* Operating System: Windows 8/8.1 (x64) or next version
* 64 bit processor (x64) i7 3.1Ghz
* 4 GB memory
* Built-in USB 3.0 host controller
* DirectX11 capable graphics adapter:
  ATI Radeon (HD 5400 series, HD 6570, HD 7800),
  NVidia Quadro (600, K1000M), NVidia GeForce (GT 640, GTX 660),
  Intel HD 4400
  
Another needs is the Kinect v2 sensor and the adapter for Windows (with power supply and USB
hub).
### Software
The project code is available at https://github.com/enryls/TheHairDouble .
The software was developed with Kinect 2.0 SDK, Kinect Fusion API and Kinect Face API in Unity3D.
For the scene in which you can create your avatar, the project was started with the Main Example
of Microsoft (DepthSource) modified for our purpose. For the other scenes and for the gesture the
starting point was the Kinect API Example of Rumen Filkov (http://rfilkov.com/).
The project is organized in seven scenes: one main menu where the mode can be selected, and
three scenes for every mode. The scripts are contained inside the Assets and are divided in three
folder:
* KScript: Contain the scripts taken from Rumen Filkov project, like GestureManager,
KinectManager and BackgroundRemoval
* KinectView: Contain the scripts of the Kinect API Example released by Microsoft like
DepthSourceManager and MultiFrameManager
* Script: Contain the scripts developed by us only for this project

## Other Details and References
For other details and references consult the Documentation PDF.
