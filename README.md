# InTheLoupe
Now that displays have such high densities of pixels, I wondered if it would be possible to make “pixel type” 2D games with actual (not scaled up) pixels and a magnifying glass to control the character through a large static map.  I put some aluminum tape on the loupe (magnifying glass) to transmit the capacitance from your fingers to the display. So to control the character all you have to do is move the loupe around the screen.  The over-world map never moves, you move your tiny character around by moving the magnifying glass
For more information on the background of the project, please see the [IDEO blog post](https://www.ideo.com/blog)

## Getting Started
* On the tablet, install “Unity Remote” [(iOS App Store)](https://apps.apple.com/us/app/unity-remote-5/id871767552) [(Google Play)](https://play.google.com/store/apps/details?id=com.unity3d.genericremote&hl=en_US)
* Open Unity and on the “Projects” page, select “open”
![open](/ReadMeImages/open.png)
* Then select the project:
![select project](/ReadMeImages/selectProject.png)
* Click “Open”
* To quickly test on a tablet, plug the tablet into a USB port on your computer, open the Unity Remote app on the tablet and in Unity on the computer go to “Edit > Project Settings > Editor and select your device.
![open](/ReadMeImages/selectDevice.png)
* Then press the play (▶) button at the top of the main Unity window and it should appear on your device.  This will let you try things out but it will be very slow to react and move the character because it is running on the computer and sending each screen as an image over the USB connection.
![open](/ReadMeImages/play.png)
* If you want to run the application natively on a device at a reasonable speed, you will need to follow the directions from Unity [“Building for Mobile”](https://learn.unity.com/tutorial/building-for-mobile) to set up your device with Unity.
