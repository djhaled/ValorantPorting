﻿global using static ValorantPorting.Services.ApplicationService;
global using Serilog;
using CUE4Parse.UE4.Objects.Core.Misc;

namespace ValorantPorting;

public static class Globals
{
    public const string DISCORD_URL = "https://discord.gg/avrJU3ggGj";
    public const string GITHUB_URL = "https://github.com/djhaled/ValorantPorting";

    public const int BLENDER_PORT = 24280;
    public const int UNREAL_PORT = 24281;
    public const int BUFFER_SIZE = 4096;
    

    public const string WHITE = "#e1e9f2";
    public const string BLUE = "#4b8ad1";
    public const string RED = "#d14b68";
    public const string YELLOW = "#d1c84b";
    public const string GREEN = "#03fc5e";

    public static readonly FGuid ZERO_GUID = new();
    public static readonly string ZERO_CHAR = "0x0000000000000000000000000000000000000000000000000000000000000000";
}