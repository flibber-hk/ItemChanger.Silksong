using Benchwarp.Data;
using ItemChanger.Silksong.RawData;

namespace ItemChangerTesting.LocationTests;

internal class ExistingChestTest : Test
{
    public override TestMetadata GetMetadata() => new()
    {
        Folder = TestFolder.LocationTests,
        MenuName = "Existing Chests",
        MenuDescription = "Creates placements for every existing chest.",
        Revision = 2026032300,
    };

    private readonly string[] chests =
    [
        LocationNames.Shell_Shard_Chest__Deep_Docks,
        LocationNames.Craftmetal__Deep_Docks,
        LocationNames.Pale_Rosary_Necklace__High_Halls_Vault,
        LocationNames.Rosary_Chest__Choral_Chambers_Northwest,
        LocationNames.Rosary_Chest__Choral_Chambers_Southwest,
        LocationNames.Rosary_Chest__Far_Fields,
        LocationNames.Rosary_Chest__High_Halls_Spire,
        LocationNames.Rosary_Chest__High_Halls_Vault_1,
        LocationNames.Rosary_Chest__High_Halls_Vault_2,
        LocationNames.Rosary_Chest__Moss_Grotto,
        LocationNames.Rosary_Chest__Sinner_s_Road,
        LocationNames.Rosary_Chest__The_Marrow,
        LocationNames.Rosary_Chest__The_Slab,
    ];


    public override void Setup(TestArgs args)
    {
        StartNear(SceneNames.Dock_06_Church, PrimitiveGateNames.right1);
        foreach (string s in chests)
        {
            Profile.AddPlacement(Finder.GetLocation(s)!.Wrap().WithDebugItem());
        }
    }
}
