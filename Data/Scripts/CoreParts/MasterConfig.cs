using System.Collections.Generic;
using System;
using System.Collections.Concurrent;
using static Scripts.Structure;
using static Scripts.Structure.WeaponDefinition;
using static Scripts.Structure.WeaponDefinition.HardPointDef;
using static Scripts.Structure.WeaponDefinition.ModelAssignmentsDef;
using static Scripts.Structure.WeaponDefinition.HardPointDef.HardwareDef;
using static Scripts.Structure.WeaponDefinition.HardPointDef.HardwareDef.HardwareType;
using static Scripts.Structure.WeaponDefinition.HardPointDef.Prediction;
using static Scripts.Structure.WeaponDefinition.TargetingDef.BlockTypes;
using static Scripts.Structure.WeaponDefinition.TargetingDef.Threat;
using static Scripts.Structure.ArmorDefinition.ArmorType;
using Sandbox.Game;
using Sandbox.Game.Entities;
using Sandbox.ModAPI;
using Sandbox.ModAPI.Interfaces.Terminal;
using Sandbox.ModAPI.Weapons;
using VRage;
using VRage.Collections;
using VRage.Game;
using VRage.Game.Entity;
using VRage.Game.ModAPI;
using VRage.Input;
using VRage.ModAPI;
using VRage.Utils;
using VRage.Voxels;
using VRageMath;
using Sandbox.Definitions;
using System.IO;

using static Sandbox.Definitions.MyDefinitionManager;
using static Scripts.Session;

namespace Scripts
{
    partial class Parts
    {
        internal Parts()
        {
            // naming convention: WeaponDefinition Name
            //
            // Enable your definitions using the follow syntax:
            // PartDefinitions(Your1stDefinition, Your2ndDefinition, Your3rdDefinition);
            // PartDefinitions includes both weapons and phantoms
            PartDefinitions(LargeGatlingTurret,
                            SmallGatlingGun,
                            SmallGatlingTurret,
                            LargeMissileLauncher,
                            LargeMissileTurret,
                            SmallMissileLauncher,
                            SmallRocketLauncherReload,
                            SmallMissileTurret,
                            LargeInteriorTurret,
                            SmallBlockAutocannon,
                            AutoCannonTurret,
                            LargeBlockAssaultCannonTurret,
                            SmallBlockAssaultCannon,
                            SmallBlockAssaultCannonTurret,
                            LargeBlockArtillery,
                            LargeBlockArtilleryTurret,
                            LargeBlockRailgun,
                            SmallBlockRailgun,
                            LargeSearchlight,
                            SmallSearchlight,
                            LargeFlare,
                            SmallFlare,
                            AdvancedHandHeldLauncherGun,
                            BasicHandHeldLauncherGun,
                            FlarePistol);
        }
    }
}
