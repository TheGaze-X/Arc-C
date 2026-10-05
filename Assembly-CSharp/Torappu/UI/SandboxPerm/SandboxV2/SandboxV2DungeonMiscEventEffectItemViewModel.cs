using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042A6 RID: 17062
	[Token(Token = "0x20042A6")]
	public class SandboxV2DungeonMiscEventEffectItemViewModel : IComparable<SandboxV2DungeonMiscEventEffectItemViewModel>, IHotfixable
	{
		// Token: 0x0601A458 RID: 107608 RVA: 0x000A0A70 File Offset: 0x0009EC70
		[Token(Token = "0x601A458")]
		[Address(RVA = "0x132FBA0", Offset = "0x132E7A0", VA = "0x18132FBA0", Slot = "4")]
		public int CompareTo(SandboxV2DungeonMiscEventEffectItemViewModel other)
		{
			return 0;
		}

		// Token: 0x0601A459 RID: 107609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A459")]
		[Address(RVA = "0x132FC40", Offset = "0x132E840", VA = "0x18132FC40")]
		public SandboxV2DungeonMiscEventEffectItemViewModel()
		{
		}

		// Token: 0x04021466 RID: 136294
		[Token(Token = "0x4021466")]
		[FieldOffset(Offset = "0x10")]
		public string effectId;

		// Token: 0x04021467 RID: 136295
		[Token(Token = "0x4021467")]
		[FieldOffset(Offset = "0x18")]
		public int instId;

		// Token: 0x04021468 RID: 136296
		[Token(Token = "0x4021468")]
		[FieldOffset(Offset = "0x1C")]
		public int day;

		// Token: 0x04021469 RID: 136297
		[Token(Token = "0x4021469")]
		[FieldOffset(Offset = "0x20")]
		public string desc;

		// Token: 0x0402146A RID: 136298
		[Token(Token = "0x402146A")]
		[FieldOffset(Offset = "0x28")]
		public int index;

		// Token: 0x0402146B RID: 136299
		[Token(Token = "0x402146B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0402146C RID: 136300
		[Token(Token = "0x402146C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
