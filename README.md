# BepInEx plugins

No warranty is provided for these plugins, and they're provided as-is.
I've tested them with one uncommon Unity/Mono game, no clue if they work in other games, so do tell me if you try them out!

## Plugins list

### SpoofHWID

Spoofs the unity getter for HWID.
I strongly oppose anything privacy invasive, and wanted to learn modding so created this as my first plugin, thusly it was created.

Malicious users will always find a way to achieve the same effect (running in VM's for example).
So I don't see an issue with providing the source code for how to do it with BepInEx.
Since other smart modders could just look at knah's similar MelonLoader mod anyway.

### FrameFocus

Allows you to limit the max framerate when alt-tabbed.

Credit to the original MelonLoader mod [with the same name by MintLily](https://github.com/MintLily/FrameFocus), which is licensed with the same GPL3 license.
This one does basically the same thing, but uses BepInEx instead of MelonLoader.

## Building

Drag the required DLL's (listed in the `shared.props` file and the `.csproj` files) into the Libs folder, open in VSCodium/VSCode press `F1` and run the build tasks. Please note that it working does depend on you having the `dotnet` command available in your environment. Or if you're not using VSC, you can just copy the commands and execute them manually on the command line.

Alternatively you can try to open the folder in Visual Studio, but I cannot provide help for using that.
If you do want to improve the situation, do feel free to contribute!

## Contributing

[Contact me](https://ljoonal.xyz/contact) or send me git patches that you want merged, or if you have an account on my git just send a PR.
