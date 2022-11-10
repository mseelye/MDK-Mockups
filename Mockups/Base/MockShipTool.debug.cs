using System;
using Sandbox.ModAPI.Ingame;
using VRage.Game.Components;
using VRage.Game.ModAPI.Ingame;
using VRageMath;

namespace IngameScript.Mockups.Base
{
#if !MOCKUP_DEBUG
    [System.Diagnostics.DebuggerNonUserCode]
#endif
    public partial class MockShipTool : MockFunctionalBlock, IMyShipToolBase
    {
        bool IMyShipToolBase.UseConveyorSystem
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        bool IMyShipToolBase.IsActivated
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
