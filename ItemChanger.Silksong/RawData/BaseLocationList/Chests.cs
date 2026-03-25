using Benchwarp.Data;
using ItemChanger.Locations;
using ItemChanger.Silksong.Containers;
using ItemChanger.Silksong.Serialization;
using ItemChanger.Tags;

namespace ItemChanger.Silksong.RawData;

// existing chest locations, including rosary chests, shell shard chests, and item chests.
internal static partial class BaseLocationList
{
    public static Location Craftmetal__Deep_Docks => new ObjectLocation
    {
        Name = LocationNames.Craftmetal__Deep_Docks,
        SceneName = SceneNames.Dock_03,
        ObjectName = "City Shard Chest",
        Correction = default,
    }.WithTag(new OriginalContainerTag
    {
        ContainerType = ContainerNames.Chest,
        Priority = true,
    });

    // 35 shards, unavailable act 3
    public static Location Shell_Shard_Chest__Deep_Docks => new DualLocation
    {
        Name = LocationNames.Shell_Shard_Chest__Deep_Docks,
        SceneName = SceneNames.Dock_06_Church,
        Test = new PDBool(nameof(PlayerData.blackThreadWorld)),
        FalseLocation = new ObjectLocation
        {
            Name = LocationNames.Shell_Shard_Chest__Deep_Docks,
            SceneName = SceneNames.Dock_06_Church,
            ObjectName = "Black Thread States Thread Only Variant/Normal World/City Shard Chest",
            Correction = default,
        }.WithTag(new OriginalContainerTag
        {
            ContainerType = ContainerNames.Chest,
            Priority = true,
        }),
        TrueLocation = new EmptyLocation
        {
            Name = LocationNames.Shell_Shard_Chest__Deep_Docks,
            SceneName = SceneNames.Dock_06_Church,
        }
    };

    public static Location Pale_Rosary_Necklace__High_Halls_Vault => new DualLocation
    {
        Name = LocationNames.Pale_Rosary_Necklace__High_Halls_Vault,
        SceneName = SceneNames.Hang_06_bank,
        Test = new PDBool(nameof(PlayerData.rosaryThievesInBank)),
        FalseLocation = new ObjectLocation
        {
            Name = LocationNames.Pale_Rosary_Necklace__High_Halls_Vault,
            SceneName = SceneNames.Hang_06_bank,
            ObjectName = "Thief Scene Control/Thieves Not Here/Chest",
            Correction = default,
        }.WithTag(new OriginalContainerTag
        {
            ContainerType = ContainerNames.Chest,
            Priority = true,
        }),
        TrueLocation = new ObjectLocation
        {
            Name = LocationNames.Pale_Rosary_Necklace__High_Halls_Vault,
            SceneName = SceneNames.Hang_06_bank,
            ObjectName = "Thief Scene Control/Thieves Here/Chest",
            Correction = default,
        }.WithTag(new OriginalContainerTag
        {
            ContainerType = ContainerNames.Chest,
            Priority = true,
        }),
    };

    // 85 rosaries
    public static Location Rosary_Chest__Choral_Chambers_Northwest => new ObjectLocation
    {
        Name = LocationNames.Rosary_Chest__Choral_Chambers_Northwest,
        SceneName = SceneNames.Song_17,
        ObjectName = "Chest Scene/Chest",
        Correction = default,
    }.WithTag(new OriginalContainerTag
    {
        ContainerType = ContainerNames.Chest,
        Priority = true,
    });

    // 60 rosaries
    public static Location Rosary_Chest__Choral_Chambers_Southwest => new ObjectLocation
    {
        Name = LocationNames.Rosary_Chest__Choral_Chambers_Southwest,
        SceneName = SceneNames.Song_03,
        ObjectName = "Chest Scene/Chest",
        Correction = default,
    }.WithTag(new OriginalContainerTag
    {
        ContainerType = ContainerNames.Chest,
        Priority = true,
    });

    // 155 rosaries
    public static Location Rosary_Chest__Far_Fields => new ObjectLocation
    {
        Name = LocationNames.Rosary_Chest__Far_Fields,
        SceneName = SceneNames.Bone_East_17,
        ObjectName = "Ant Chest",
        Correction = default,
    }.WithTag(new OriginalContainerTag
    {
        ContainerType = ContainerNames.Chest,
        Priority = true,
    });

    // 60 rosaries
    public static Location Rosary_Chest__High_Halls_Spire => new ObjectLocation
    {
        Name = LocationNames.Rosary_Chest__High_Halls_Spire,
        SceneName = SceneNames.Hang_08,
        ObjectName = "Chest Scene/Chest",
        Correction = default,
    }.WithTag(new OriginalContainerTag
    {
        ContainerType = ContainerNames.Chest,
        Priority = true,
    });

    // 25 rosaries
    public static Location Rosary_Chest__High_Halls_Vault_1 => new DualLocation
    {
        Name = LocationNames.Rosary_Chest__High_Halls_Vault_1,
        SceneName = SceneNames.Hang_06_bank,
        Test = new PDBool(nameof(PlayerData.rosaryThievesInBank)),
        FalseLocation = new ObjectLocation
        {
            Name = LocationNames.Rosary_Chest__High_Halls_Vault_1,
            SceneName = SceneNames.Hang_06_bank,
            ObjectName = "Thief Scene Control/Thieves Not Here/Chest (1)",
            Correction = default,
        }.WithTag(new OriginalContainerTag
        {
            ContainerType = ContainerNames.Chest,
            Priority = true,
        }),
        TrueLocation = new ObjectLocation
        {
            Name = LocationNames.Rosary_Chest__High_Halls_Vault_1,
            SceneName = SceneNames.Hang_06_bank,
            ObjectName = "Thief Scene Control/Thieves Here/Chest (1)",
            Correction = default,
        }.WithTag(new OriginalContainerTag
        {
            ContainerType = ContainerNames.Chest,
            Priority = true,
        }),
    };

    // 45 rosaries
    public static Location Rosary_Chest__High_Halls_Vault_2 => new DualLocation
    {
        Name = LocationNames.Rosary_Chest__High_Halls_Vault_2,
        SceneName = SceneNames.Hang_06_bank,
        Test = new PDBool(nameof(PlayerData.rosaryThievesInBank)),
        FalseLocation = new ObjectLocation
        {
            Name = LocationNames.Rosary_Chest__High_Halls_Vault_2,
            SceneName = SceneNames.Hang_06_bank,
            ObjectName = "Thief Scene Control/Thieves Not Here/Chest (2)",
            Correction = default,
        }.WithTag(new OriginalContainerTag
        {
            ContainerType = ContainerNames.Chest,
            Priority = true,
        }),
        TrueLocation = new ObjectLocation
        {
            Name = LocationNames.Rosary_Chest__High_Halls_Vault_2,
            SceneName = SceneNames.Hang_06_bank,
            ObjectName = "Thief Scene Control/Thieves Here/Chest (2)",
            Correction = default,
        }.WithTag(new OriginalContainerTag
        {
            ContainerType = ContainerNames.Chest,
            Priority = true,
        }),
    };

    // 30 rosaries
    public static Location Rosary_Chest__Moss_Grotto => new ObjectLocation
    {
        Name = LocationNames.Rosary_Chest__Moss_Grotto,
        SceneName = SceneNames.Tut_01,
        ObjectName = "Bone Chest",
        Correction = default,
    }.WithTag(new OriginalContainerTag
    {
        ContainerType = ContainerNames.Chest,
        Priority = true,
    });

    // 112 rosaries
    public static Location Rosary_Chest__Sinner_s_Road => new ObjectLocation
    {
        Name = LocationNames.Rosary_Chest__Sinner_s_Road,
        SceneName = SceneNames.Dust_05,
        ObjectName = "Pilgrim Chest",
        Correction = default,
    }.WithTag(new OriginalContainerTag
    {
        ContainerType = ContainerNames.Chest,
        Priority = true,
    });

    // 60 rosaries
    public static Location Rosary_Chest__The_Marrow => new ObjectLocation
    {
        Name = LocationNames.Rosary_Chest__The_Marrow,
        SceneName = SceneNames.Bone_19,
        ObjectName = "Bone Chest",
        Correction = default,
    }.WithTag(new OriginalContainerTag
    {
        ContainerType = ContainerNames.Chest,
        Priority = true,
    });

    // 115 rosaries
    public static Location Rosary_Chest__The_Slab => new ObjectLocation
    {
        Name = LocationNames.Rosary_Chest__The_Slab,
        SceneName = SceneNames.Slab_19b,
        ObjectName = "City Shard Chest",
        Correction = default,
    }.WithTag(new OriginalContainerTag
    {
        ContainerType = ContainerNames.Chest,
        Priority = true,
    });
}
