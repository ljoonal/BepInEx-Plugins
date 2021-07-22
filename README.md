# CVR-Mods

No warranty is provided for these mods, and they're provided as-is.

## Why use BepInEx and not MelonLoader

If you're asking: "MelonLoader is the tool used with X game modding, so why not use it for Y too?"

While it's a great tool, it requires .NET framework. Which is not available for linux.
I can actually build my mods on Linux with BepInEx unlike MelonLoader.
This is also why the build system is with VSC tasks instead of Visual Studio in this repository.

MelonLoader also does not have a few features that BepInEx does, and BepInEx just seems way more mature for modding Unity (non-IL2CPP) games.

## Mod list

### SpoofHWID

A non-IL2CPP Unity BepInEx mod to spoof the HWID.
I strongly oppose anything privacy invasive, and wanted to learn modding so created this as my first plugin, thusly it was created.

Malicious users will always find a way to achieve the same effect (running in VM's for example).
So I don't see an issue with providing the source code for how to do it with BepInEx.
Since other smart modders could just look at knah's similar MelonLoader mod anyway.

### FrameFocus

Credit to the original MelonLoader mod [with the same name by MintLily](https://github.com/MintLily/FrameFocus), which is licensed with the same GPL3 license.
This one does basically the same thing, but uses BepInEx instead of MelonLoader.

Allows you to limit the max framerate when alt-tabbed.

## Building

Drag the required DLL's (listed in the .csproj files) into the Libs folder, open in VSCodium press `F1` and run the build tasks. Please note that it working does depend on you having the `dotnet` command available in your environment.

Alternatively you can try to open the folder in Visual Studio, but I cannot provide help for using that.

## Contributing

Contact me on Discord or send me git patches that you want merged.
