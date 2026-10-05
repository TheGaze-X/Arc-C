using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Roguelike
{
	// Token: 0x0200292B RID: 10539
	[Token(Token = "0x200292B")]
	public abstract class BasicDeckCardRelic : BasicRelic
	{
		// Token: 0x170026A9 RID: 9897
		// (get) Token: 0x06011799 RID: 71577 RVA: 0x0006B868 File Offset: 0x00069A68
		[Token(Token = "0x170026A9")]
		public override BasicRelic.RelicType relicType
		{
			[Token(Token = "0x6011799")]
			[Address(RVA = "0x94E610", Offset = "0x94D210", VA = "0x18094E610", Slot = "4")]
			get
			{
				return BasicRelic.RelicType.NONE;
			}
		}

		// Token: 0x0601179A RID: 71578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601179A")]
		[Address(RVA = "0x94E500", Offset = "0x94D100", VA = "0x18094E500", Slot = "7")]
		public override void Preprocess(ref BasicRelic.RelicInOut inOut)
		{
		}

		// Token: 0x0601179B RID: 71579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601179B")]
		[Address(RVA = "0x94E5B0", Offset = "0x94D1B0", VA = "0x18094E5B0")]
		protected BasicDeckCardRelic()
		{
		}

		// Token: 0x0601179C RID: 71580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601179C")]
		[Address(RVA = "0x94E430", Offset = "0x94D030", VA = "0x18094E430")]
		private void <>xLuaBaseProxy_Preprocess(ref BasicRelic.RelicInOut P0)
		{
		}

		// Token: 0x040138AA RID: 80042
		[Token(Token = "0x40138AA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_relicType;

		// Token: 0x040138AB RID: 80043
		[Token(Token = "0x40138AB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Preprocess;

		// Token: 0x040138AC RID: 80044
		[Token(Token = "0x40138AC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
