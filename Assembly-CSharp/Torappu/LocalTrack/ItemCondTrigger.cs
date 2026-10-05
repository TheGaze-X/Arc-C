using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.LocalTrack
{
	// Token: 0x0200208C RID: 8332
	[Token(Token = "0x200208C")]
	public class ItemCondTrigger : PlayerTrackTrigger
	{
		// Token: 0x0600CD57 RID: 52567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CD57")]
		[Address(RVA = "0x3503760", Offset = "0x3502360", VA = "0x183503760", Slot = "4")]
		public override string GetDataID()
		{
			return null;
		}

		// Token: 0x0600CD58 RID: 52568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD58")]
		[Address(RVA = "0x35037C0", Offset = "0x35023C0", VA = "0x1835037C0")]
		public ItemCondTrigger()
		{
		}

		// Token: 0x0400D8A3 RID: 55459
		[Token(Token = "0x400D8A3")]
		[FieldOffset(Offset = "0x20")]
		public string itemId;

		// Token: 0x0400D8A4 RID: 55460
		[Token(Token = "0x400D8A4")]
		[FieldOffset(Offset = "0x28")]
		public int targetCount;

		// Token: 0x0400D8A5 RID: 55461
		[Token(Token = "0x400D8A5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetDataID;

		// Token: 0x0400D8A6 RID: 55462
		[Token(Token = "0x400D8A6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
