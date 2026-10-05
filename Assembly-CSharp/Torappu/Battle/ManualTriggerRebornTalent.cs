using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200248F RID: 9359
	[Token(Token = "0x200248F")]
	public class ManualTriggerRebornTalent : RebornTalent
	{
		// Token: 0x0600F0A5 RID: 61605 RVA: 0x00058B00 File Offset: 0x00056D00
		[Token(Token = "0x600F0A5")]
		[Address(RVA = "0x675970", Offset = "0x674570", VA = "0x180675970", Slot = "26")]
		public override bool CheckReborn(out Unit.RebornData respawnData)
		{
			return default(bool);
		}

		// Token: 0x0600F0A6 RID: 61606 RVA: 0x00058B18 File Offset: 0x00056D18
		[Token(Token = "0x600F0A6")]
		[Address(RVA = "0x675760", Offset = "0x674360", VA = "0x180675760")]
		public bool CanBeManualTriggered(out Unit.RebornData respawnData)
		{
			return default(bool);
		}

		// Token: 0x0600F0A7 RID: 61607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0A7")]
		[Address(RVA = "0x675A00", Offset = "0x674600", VA = "0x180675A00")]
		public ManualTriggerRebornTalent()
		{
		}

		// Token: 0x0600F0A8 RID: 61608 RVA: 0x00058B30 File Offset: 0x00056D30
		[Token(Token = "0x600F0A8")]
		[Address(RVA = "0x6759F0", Offset = "0x6745F0", VA = "0x1806759F0")]
		private bool <>xLuaBaseProxy_CheckReborn(out Unit.RebornData P0)
		{
			return default(bool);
		}

		// Token: 0x04010A2A RID: 68138
		[Token(Token = "0x4010A2A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckReborn;

		// Token: 0x04010A2B RID: 68139
		[Token(Token = "0x4010A2B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CanBeManualTriggered;

		// Token: 0x04010A2C RID: 68140
		[Token(Token = "0x4010A2C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
