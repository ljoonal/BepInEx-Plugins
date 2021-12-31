# BepInEx plugins

No warranty is provided for these plugins, and they're provided as-is.
I've tested them with one uncommon Unity/Mono game, no clue if they work in other games, so do tell me if you try them out!

## Plugins list

### HWID Spoofer

Spoofs the unity getter for HWID.
I strongly oppose anything privacy invasive, and wanted to learn modding so created this as my first plugin.

Malicious users will always find a way to achieve the same effect (running in VM's for example).
So I don't see an issue with providing the source code for how to do it with BepInEx.
Since other smart modders could just look at [knah's similar MelonLoader mod](https://github.com/knah/ML-UniversalMods#hwidpatch) anyway, which was the inspiration for this plugin and is licensed under the same GPL3.

### Frame Focus

Allows you to limit the max framerate when alt-tabbed.

Credit to the original MelonLoader mod [with the same name by MintLily](https://github.com/MintLily/FrameFocus), which is licensed with the same GPL3 license.
This one does basically the same thing, but uses BepInEx instead of MelonLoader.

### Input Finder

Logs the currently pressed keys when enabled, which will allow you to find the KeyCode's to things just by pressing them.
It's recommended to set the `Enabled` config value to false when actually playing the game, since getting all the possible keys will most likely impact your performance.

### Mouse Control

A mod that force locks the mouse to the game constantly.

## Building

Drag the required DLL's (listed in the `Directory.Build.props` file and the `.csproj` files) into the Libs folder.
Then use the `dotnet build` command to build.

Alternatively you can try to open the folder in Visual Studio, but I cannot provide help for using that.
If you do want to improve the situation, do feel free to contribute!

## Contributing

[Contact me](https://ljoonal.xyz/contact) or send me git patches that you want merged, or if you have an account on my git just send a PR.
