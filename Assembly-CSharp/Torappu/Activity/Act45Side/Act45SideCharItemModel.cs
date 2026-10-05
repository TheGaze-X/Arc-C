using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act45Side
{
	// Token: 0x020072C5 RID: 29381
	[Token(Token = "0x20072C5")]
	public class Act45SideCharItemModel : IHotfixable
	{
		// Token: 0x06029967 RID: 170343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029967")]
		[Address(RVA = "0x24F1AA0", Offset = "0x24F06A0", VA = "0x1824F1AA0")]
		public Act45SideCharItemModel()
		{
		}

		// Token: 0x0403B78A RID: 243594
		[Token(Token = "0x403B78A")]
		[FieldOffset(Offset = "0x10")]
		public string charId;

		// Token: 0x0403B78B RID: 243595
		[Token(Token = "0x403B78B")]
		[FieldOffset(Offset = "0x18")]
		public bool isReceived;

		// Token: 0x0403B78C RID: 243596
		[Token(Token = "0x403B78C")]
		[FieldOffset(Offset = "0x20")]
		public string frontImgId;

		// Token: 0x0403B78D RID: 243597
		[Token(Token = "0x403B78D")]
		[FieldOffset(Offset = "0x28")]
		public string backImgId;

		// Token: 0x0403B78E RID: 243598
		[Token(Token = "0x403B78E")]
		[FieldOffset(Offset = "0x30")]
		public string unlockLevelName;

		// Token: 0x0403B78F RID: 243599
		[Token(Token = "0x403B78F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
