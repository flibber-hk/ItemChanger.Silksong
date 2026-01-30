using ItemChanger.Items;
using ItemChanger.Serialization;
using ItemChanger.Silksong.Items;
using ItemChanger.Silksong.Serialization;
using ItemChanger.Silksong.UIDefs;

namespace ItemChanger.Silksong.RawData
{
    internal static class BaseItemList
    {
        public static Item Surgeon_s_Key => new ItemChangerCollectableItem
        {
            Name = ItemNames.Surgeon_s_Key,
            CollectableName = "Ward Boss Key",
            UIDef = new CollectableUIDef { CollectableName = "Ward Boss Key" },
        };

        public static Item Mossberry_Stew => new ItemChangerCollectableItem
        {
            Name = ItemNames.Mossberry_Stew,
            CollectableName = "Mossberry Stew",
            UIDef = new CollectableUIDef { CollectableName = "Mossberry Stew" },
        };

        public static Item Crest_of_Hunter => new ItemChangerCollectableItem
        {
            Name = ItemNames.Crest_of_Hunter,
            CollectableName = "Hunter",
            UIDef = new CollectableUIDef { CollectableName = "Hunter" },
        };
        public static Item Crest_of_Hunter_v2 => new ItemChangerCollectableItem
        {
            Name = ItemNames.Crest_of_Hunter_v2,
            CollectableName = "Hunter_v2",
            UIDef = new CollectableUIDef { CollectableName = "Hunter_v2" },
        };
        public static Item Crest_of_Hunter_v3 => new ItemChangerCollectableItem
        {
            Name = ItemNames.Crest_of_Hunter_v3,
            CollectableName = "Hunter_v3",
            UIDef = new CollectableUIDef { CollectableName = "Hunter_v3" },
        };

        public static Item Crest_of_Wanderer => new ItemChangerCollectableItem
        {
            Name = ItemNames.Crest_of_Wanderer,
            CollectableName = "Wanderer",
            UIDef = new CollectableUIDef { CollectableName = "Wanderer" },
        };
        public static Item Cloakless => new ItemChangerCollectableItem
        {
            Name = ItemNames.Cloakless,
            CollectableName = "Cloakless",
            UIDef = new CollectableUIDef { CollectableName = "Cloakless" },
        };

        public static Item Cross_Stitch => new ItemChangerCollectableItem
        {
            Name = ItemNames.Cross_Stitch,
            CollectableName = "Parry",
            UIDef = new CollectableUIDef { CollectableName = "Parry" },
        };

        public static Item Tacks => new ItemChangerCollectableItem
        {
            Name = ItemNames.Tacks,
            CollectableName = "Tack",
            UIDef = new CollectableUIDef { CollectableName = "Tack" },
        };

        public static Item Multibinder => new ItemChangerCollectableItem
        {
            Name = ItemNames.Multibinder,
            CollectableName = "Multibind",
            UIDef = new CollectableUIDef { CollectableName = "Multibind" },
        };

        public static Item Compass => new ItemChangerCollectableItem
        {
            Name = ItemNames.Compass,
            CollectableName = "Compass",
            UIDef = new CollectableUIDef { CollectableName = "Compass" },
        };

        public static Item Vaultkeeper_s_Melody => new ItemChangerCollectableItem
        {
            Name = ItemNames.Vaultkeeper_s_Melody,
            CollectableName = "Librarian Melody Cylinder",
            UIDef = new CollectableUIDef { CollectableName = "Librarian Melody Cylinder" },
        };

        public static Item Arcane_Egg => new ItemChangerCollectableItem
        {
            Name = ItemNames.Arcane_Egg,
            CollectableName = "Ancient Egg Abyss Middle",
            UIDef = new CollectableUIDef { CollectableName = "Ancient Egg Abyss Middle" },
        };

        public static Dictionary<string, Item> GetBaseItems()
        {
            return typeof(BaseItemList).GetProperties().Select(p => (Item)p.GetValue(null)).ToDictionary(i => i.Name);
        }
    }
}
