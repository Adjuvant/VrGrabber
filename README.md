VrGrabber
=========

**VrGrabber** is a VR grabber components for Unity.

-   Both-hands interaction (move, rotate, and scale)
-   Z-distance control by thumb sticks
-   Connect objects with a curved line

![VrGrabber Image 1](https://raw.githubusercontent.com/wiki/hecomi/VrGrabber/grabber1.PNG)
![VrGrabber Image 2](https://raw.githubusercontent.com/wiki/hecomi/VrGrabber/grabber2.PNG)
![VrGrabber Image 3](https://raw.githubusercontent.com/wiki/hecomi/VrGrabber/grabber3.PNG)

-   Currently only Oculus SDK, NewtonVR (Steam and Oculus) are supported ( VRTK, Unity native and native OpenVR will be supported soon).

Demo
----

-   [https://www.youtube.com/watch?v=x-NaOaJp0xc](https://www.youtube.com/watch?v=x-NaOaJp0xc)

Setup
-------

1.  Download the latest *.unitypackage* from [Release](https://github.com/hecomi/VrGrabber/releases) page.
2.  Import it into your project.
3.  Add `Vrg Left Grabber` and `Vrg Right Grabber` from *VrGrabber > Prefabs*
    to your VR tracking rig e.g. Oculus: `TrackingSpace` under `OVRCameraRig`.

Dependencies
-------

When importing be careful about overwriting project and input settings!

+ Oculus SDK 1.35
+ NewtonVR 1.24
+ VRTK 3.3
+ SteamVR 1.2.3

All these folders are hidden in the git uploads!

TODO
-------
+ [ ] VRTK input control
+ [ ] Native UnityXR input control
+ [ ] Native SteamVR input control


License
-------

The MIT License (MIT)

Copyright (c) 2017 hecomi
Copyright (c) 2019 adjuvant

Permission is hereby granted, free of charge, to any person obtaining a copy of
this software and associated documentation files (the "Software"), to deal in
the Software without restriction, including without limitation the rights to
use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
the Software, and to permit persons to whom the Software is furnished to do so,
subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
