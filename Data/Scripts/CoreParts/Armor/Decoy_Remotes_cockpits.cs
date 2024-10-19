using static Scripts.Structure;
using static Scripts.Structure.ArmorDefinition.ArmorType;
namespace Scripts
{
    partial class Parts
    {
        // Don't edit above this line
        ArmorDefinition Decoy_Remote_Cockpits => new ArmorDefinition
        {
            SubtypeIds = new[] {
                "TrussPillarDecoy",
                "LargeDecoy",
                "SmallDecoy",
                "SmallBlockRemoteControl",
                "LargeBlockRemoteControl",
                "RivalAIRemoteControlLarge",
                "RivalAIRemoteControlSmall",
                "LargeBlockCockpitSeat",
                "SmallBlockCockpitSeat",
                "SmallBlockCockpit",
                "DBSmallBlockFighterCockpit",
                "SmallBlockCockpitIndustrial",
                "LargeBlockCockpitIndustrial",
                "SmallBlockCapCockpit",
                "SmallBlockFlushCockpit",
                "BuggyCockpit",
                "SpeederCockpitCompact",
                "SpeederCockpit",
                "OpenCockpitSmall",
                "RoverCockpit",
                "SmallBlockStandingCockpit",
                "LargeBlockStandingCockpit",
                "OpenCockpitLarge",
                "LargeBlockCockpit",
                "CockpitOpen",
                "SurvivalKitLarge",
                "SurvivalKit",
                "LargeMedicalRoom",
                "LargeMedicalRoomReskin",
            },
            EnergeticResistance = 4f, //Resistance to Energy damage. 0.5f = 200% damage, 2f = 50% damage
            KineticResistance = 4f, //Resistance to Kinetic damage. Leave these as 1 for no effect
            Kind = NonArmor, //Heavy, Light, NonArmor - which ammo damage multipliers to apply
        };
    }
}