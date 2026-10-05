using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005620 RID: 22048
	[Token(Token = "0x2005620")]
	public class RL05DungeonGeneSpZonePlugin : RoguelikeDungeonGeneSpZonePluginBase
	{
		// Token: 0x060205B7 RID: 132535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60205B7")]
		[Address(RVA = "0x1A74D10", Offset = "0x1A73910", VA = "0x181A74D10", Slot = "4")]
		public override RoguelikeDungeonZone GenSpZoneCurrentDungeonZone(PlayerRoguelikeV2Zone playerZone)
		{
			return null;
		}

		// Token: 0x060205B8 RID: 132536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60205B8")]
		[Address(RVA = "0x1A75180", Offset = "0x1A73D80", VA = "0x181A75180")]
		public RL05DungeonGeneSpZonePlugin()
		{
		}

		// Token: 0x0402BCB6 RID: 179382
		[Token(Token = "0x402BCB6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GenSpZoneCurrentDungeonZone;

		// Token: 0x0402BCB7 RID: 179383
		[Token(Token = "0x402BCB7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
