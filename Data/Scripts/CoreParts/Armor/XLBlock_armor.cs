using static Scripts.Structure;
using static Scripts.Structure.ArmorDefinition.ArmorType;
namespace Scripts
{
    partial class Parts
    {
        // Don't edit above this line
        ArmorDefinition XLblocks => new ArmorDefinition
        {
            SubtypeIds = new[] {
                "XL_Block",
                "XL_BlockDetail",
                "XL_BlockHazard",
                "XL_BlockInvCorner",
                "XL_BlockSlope",
                "XL_BlockCorner",
                "XL_BlockFrame",
                "XL_HalfBlock",
                "XL_HalfBlockCorner",
		        "XL_HalfCornerBase",
                "XL_HalfCornerTip",
		        "XL_HalfCornerBaseInv",
	        	"XL_HalfCornerTipInv",
		        "XL_HalfSlopeBase",
	        	"XL_HalfSlopeTip",
                "XL_1x",
                "XL_1xPlatform",
                "XL_1xMount",
                "XL_1xFrame",
                "XL_PassageCorner",
                "XL_Passage",
                "XL_Hip",
		        "XL_Brace",
                "XL_BlockSlopedCorner",
                "XL_BlockSlopedCornerBase",
                "XL_BlockSlopedCornerTip",
            },
            EnergeticResistance = .5f, //Resistance to Energy damage. 0.5f = 200% damage, 2f = 50% damage
            KineticResistance = .5f, //Resistance to Kinetic damage. Leave these as 1 for no effect
            Kind = Heavy, //Heavy, Light, NonArmor - which ammo damage multipliers to apply
        };
    }
}