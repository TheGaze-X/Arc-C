using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042A1 RID: 17057
	[Token(Token = "0x20042A1")]
	public class SandboxV2DungeonMiscExpeditionItemViewModel : IComparable<SandboxV2DungeonMiscExpeditionItemViewModel>, IHotfixable
	{
		// Token: 0x0601A44C RID: 107596 RVA: 0x000A0A28 File Offset: 0x0009EC28
		[Token(Token = "0x601A44C")]
		[Address(RVA = "0x132FFA0", Offset = "0x132EBA0", VA = "0x18132FFA0", Slot = "4")]
		public int CompareTo(SandboxV2DungeonMiscExpeditionItemViewModel other)
		{
			return 0;
		}

		// Token: 0x0601A44D RID: 107597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A44D")]
		[Address(RVA = "0x1330050", Offset = "0x132EC50", VA = "0x181330050")]
		public SandboxV2DungeonMiscExpeditionItemViewModel()
		{
		}

		// Token: 0x04021449 RID: 136265
		[Token(Token = "0x4021449")]
		[FieldOffset(Offset = "0x10")]
		public string expeditionId;

		// Token: 0x0402144A RID: 136266
		[Token(Token = "0x402144A")]
		[FieldOffset(Offset = "0x18")]
		public string desc;

		// Token: 0x0402144B RID: 136267
		[Token(Token = "0x402144B")]
		[FieldOffset(Offset = "0x20")]
		public int index;

		// Token: 0x0402144C RID: 136268
		[Token(Token = "0x402144C")]
		[FieldOffset(Offset = "0x24")]
		public int day;

		// Token: 0x0402144D RID: 136269
		[Token(Token = "0x402144D")]
		[FieldOffset(Offset = "0x28")]
		public List<SandboxV2DungeonExpeditionChar> chars;

		// Token: 0x0402144E RID: 136270
		[Token(Token = "0x402144E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0402144F RID: 136271
		[Token(Token = "0x402144F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
