using GlobalEnums;
using ItemChanger.Items;
using ItemChanger.Serialization;
using ItemChanger.Silksong.Items;
using ItemChanger.Silksong.Modules.FastTravel;
using ItemChanger.Silksong.Serialization;
using ItemChanger.Silksong.UIDefs;

namespace ItemChanger.Silksong.RawData;

internal static partial class BaseItemList
{
    // TODO - add shop descs

    private static UIDef GetBellwayUIDef(LanguageString station)
    {
        return new MsgUIDef()
        {
            Name = CompositeString.Create(
                LanguageString.FromItemChanger("FMT_FAST_TRAVEL_PATTERN"),
                new Dictionary<string, IValueProvider<object>>
                {
                    { "TRAVEL_TYPE", BaseLanguageStrings.Bellway },
                    { "STATION_NAME", station }
                }),
            ShopDesc = null!,
            Sprite = BaseAtlasSprites.Bellway, 
        };
    }

    private static UIDef GetVentricaUIDef(LanguageString station)
    {
        return new MsgUIDef()
        {
            Name = CompositeString.Create(
                LanguageString.FromItemChanger("FMT_FAST_TRAVEL_PATTERN"),
                new Dictionary<string, IValueProvider<object>>
                {
                    { "TRAVEL_TYPE", BaseLanguageStrings.Ventrica },
                    { "STATION_TYPE", station } 
                }),
            ShopDesc = null!,
            Sprite = BaseAtlasSprites.Ventrica,
        };
    }

    // Bellway

    public static Item Bellway__Bone_Bottom => new PDBoolItem()
    {
        Name = ItemNames.Bellway__Bone_Bottom,
        BoolName = CustomFastTravelLocations.GetBoolStringForLocation(FastTravelLocations.Bonetown),
        UIDef = GetBellwayUIDef(BaseLanguageStrings.Fast_Travel__STATION_NAME_BONETOWN),
    };

    public static Item Bellway__The_Marrow => new PDBoolItem()
    {
        Name = ItemNames.Bellway__The_Marrow,
        BoolName = CustomFastTravelLocations.GetBoolStringForLocation(FastTravelLocations.Bone),
        UIDef = GetBellwayUIDef(BaseLanguageStrings.Fast_Travel__STATION_NAME_BONE),
    };

    public static Item Bellway__Bilewater => new PDBoolItem()
    {
        Name = ItemNames.Bellway__Bilewater,
        BoolName = nameof(PlayerData.UnlockedShadowStation),
        UIDef = GetBellwayUIDef(BaseLanguageStrings.Fast_Travel__STATION_NAME_SHADOW),
    };

    // Ventrica

    public static Item Ventrica__Terminus => new PDBoolItem()
    {
        Name = ItemNames.Ventrica__Terminus,
        BoolName = CustomFastTravelLocations.GetBoolStringForLocation(TubeTravelLocations.Hub),
        UIDef = GetVentricaUIDef(BaseLanguageStrings.Fast_Travel__TUBE_NAME_HUB),
    };

    public static Item Ventrica__High_Halls => new PDBoolItem()
    {
        Name = ItemNames.Ventrica__High_Halls,
        BoolName = nameof(PlayerData.UnlockedHangTube),
        UIDef = GetVentricaUIDef(BaseLanguageStrings.Fast_Travel__TUBE_NAME_HANG),
    };

    // TODO - others (can be done as part of a refactored PR #37)
}
