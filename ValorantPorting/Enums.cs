﻿using System.ComponentModel;

namespace ValorantPorting;

public enum EInstallType
{
    [Description("Local")]
    Local,
    
    [Description("Valorant Live")]
    Live
}

public enum ERichPresenceAccess
{
    [Description("Always")]
    Always,
    
    [Description("Never")]
    Never
}
public enum EMeshType
{
    [Description("Base")]
    Base,

    [Description("Overriden")]
    Overriden
}

public enum EWeaponType
{
    [Description("Attatchment")]
    Attatchment,
    [Description("RealWeapon")]
    RealWeapon,
}
public enum EAssetType
{
    [Description("Characters")]
    Character,
    [Description("Weapons")]
    Weapon,
    [Description("GunBuddies")]
    GunBuddy,
    [Description("Maps")]
    Maps,
    [Description("Bundles")]
    Bundles,

    /*[Description("Props")]
    Prop,
    
    [Description("Meshes")]
    Mesh,*/
}

public enum EValBodyType : byte
{
    FP = 0,
    TP = 1,
}