using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace EnumCollection
{
    public enum Levels
    {
        Intro,
        Main,
        Game
    }
    public enum PlayerPrefKeys
    {
        Music,
        Sound,
        UserLevel,
        UpgradeTreeIdx,
        UG_ORIENTATION,
        Vibration,
        Joystick,
        VisualEffects,
        Graphics,
        GameCurrency = 10000, //used for shop prices
        UserAccountResources,
        LastEnergyTime,
        Resources,
        GameLevelUnlocked,
        CurrentLevel,
        RecordTime
    }

    public enum SceneIndex
    {
        Loading = 0,
        Main = 1,
        Game = 2
    }
    
    public enum UserAccountResources
    {
        Coin,
        Gem,
        Energy
    }

    public enum ShopItemType
    {
        Consumable,
        OneTimePurchase,
        Free
    }

    public enum Sound
    {WAAAAAAAAAA,
        Yippee,
        ButtonClickSound,
        MenuTheme,
        GameTheme,
        BossTheme,
        ProjectileThrow,
        GemPickUp,
        EnemyDeathSound1,
        EnemyDeathSound2,
        AirFlowSound,
        EnemyIncoming,
        ElectricLightning,
        CoinPickUp,
        MagnetPickUp,
        PopupShow,
        PopupHide,
        LuckyWheel,
        Guardian,
        MolotovGlass,
        Fire,
        Boomerang,
        Impact,
        Forcefield,
        ButtonClickSound2,
        BossTransition
    }

    public enum LevelFormat
    {
        Open
    }

    public enum SkillType
    {
        Active,
        Passive
    }

    public enum SkillName
    {
        // Active Skills
        
        [Description(nameof(SkillType.Active))]
        DefaultWeapon,

        [Description(nameof(SkillType.Active))]
        Boomerang,

        [Description(nameof(SkillType.Active))]
        BrickShot,
        
        [Description(nameof(SkillType.Active))]
        DrillShot,
        
        [Description(nameof(SkillType.Active))]
        Guardian,

        [Description(nameof(SkillType.Active))]
        Molotov,
        
        [Description(nameof(SkillType.Active))]
        TypeADrone,
        
        [Description(nameof(SkillType.Active))]
        TypeBDrone,

        [Description(nameof(SkillType.Active))]
        Ball,
        
        [Description(nameof(SkillType.Active))]
        LightningEmitter,
        
        [Description(nameof(SkillType.Active))]
        Forcefield,
        
        // Evo
        
        [Description(nameof(SkillType.Active))]
        DestroyerEvo,
        
        // Passive Skills
        
        [Description(nameof(SkillType.Passive))]
        Magnet,
        
        [Description(nameof(SkillType.Passive))]
        FitnessGuide,
        
        [Description(nameof(SkillType.Passive))]
        AmmoThruster,
        
        [Description(nameof(SkillType.Passive))]
        HeFuel,
        
        [Description(nameof(SkillType.Passive))]
        EnergyDrink,
        
        [Description(nameof(SkillType.Passive))]
        ExoBracer,
        
        [Description(nameof(SkillType.Passive))]
        OilBond,
        
        [Description(nameof(SkillType.Passive))]
        RoninOyoroi,

        [Description(nameof(SkillType.Passive))]
        SportsShoes,
        
        [Description(nameof(SkillType.Passive))]
        KogaNinjaScroll,
        
    }

    public enum ShopItemCurrencyType
    {
        Coin,
        Gem,
        Chest,
    }
    
    public class EnumUtil
    {
        public static string GetDescription(Enum e)
        {
            var attribute =
                e.GetType()
                        .GetTypeInfo()
                        .GetMember(e.ToString())
                        .FirstOrDefault(member => member.MemberType == MemberTypes.Field)
                        ?.GetCustomAttributes(typeof(DescriptionAttribute), false)
                        .SingleOrDefault()
                    as DescriptionAttribute;

            return attribute?.Description ?? e.ToString();
        }
    }

    public enum ShootingPatterns
    {
        CircleShootingPattern,
        TriangleShootPattern,
        SquareShootPattern,
        SeparatedShootPattern,
        MultipleDirectShootPattern,
        DirectRangedShootPattern
    }

    public enum EnemyProjectileHitBehaviour
    {
        SelfDestroy,
        HitObjectDestroy,
        SelfDisable,
        HitObjectDisable,
        Nothing
    }
}