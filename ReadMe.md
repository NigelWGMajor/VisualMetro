# VisualMetro

## A visual on-screen metronome.

This is a vst plug-in I use inside (Reaper)[https://www.reaper.fm/] (I have not needed to test in other DAWs) to display a visual metronome using a moving dot somewhat like a conductor's baton.  

This uses the superb C# wrapper library [Vst.net](https://github.com/obiwanjacobi/vst.net) by Obiwanjacobi which in turn uses the [Steinberg VST SDK](https://www.steinberg.net/en/company/developers.html).

The jacobi.vst.core.dll and jacobi.vst.framework.dll are loaded from the _lib folder:  you should download those yourself from the Jacobi repo.  You will also need the jacobi.vst.interop.dll which you will rename as described below.

## To deploy

Build in release mode (visual studio).

If the references are broken, you will need to get them from the Jacobi site and place them in a suitable location - I use a _lib folder one level up which is shared among multiple projects of his nature. (Actually for the newer versions x64 dotnet 4.0, I now have these in the GAC - have not had a chabce to update thius one yet).

The Metro.dll wrapper in the output folder is the actual vst seen by the DAW ... this is a renamed copy of the jacobi.vst.interop.dll as described in his documentation: it wraps the managed component which must be named metro.net.dll.

Deployment to the DAW involves copying these files to (a folder in) the DAW plugin folder:

- Jacobi.Vst.Core.dll
- Jacobi.Vst.Framework.dll
- Metro.dll
- Metro.net.dll

Reaper should then find the vst and make it available.

## To use:

- Create a track, and insert a time code generator on it. (This depends on whether you have external hardware generating midi time codes ...)
- Add the Metro effect.
- Disable the Master send from this track (unless you want to hear the timecode!)
- Stretch the timecode out across the duration of the project!
- Ensure that the time signature and tempo are set appropriately.
- The metronome should do its thing.