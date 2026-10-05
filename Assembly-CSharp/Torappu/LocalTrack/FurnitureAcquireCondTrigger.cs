using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.LocalTrack
{
	// Token: 0x0200208A RID: 8330
	[Token(Token = "0x200208A")]
	public class FurnitureAcquireCondTrigger : PlayerTrackTrigger
	{
		// Token: 0x0600CD51 RID: 52561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CD51")]
		[Address(RVA = "0x34FF780", Offset = "0x34FE380", VA = "0x1834FF780", Slot = "4")]
		public override string GetDataID()
		{
			return null;
		}

		// Token: 0x0600CD52 RID: 52562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD52")]
		[Address(RVA = "0x34FF7E0", Offset = "0x34FE3E0", VA = "0x1834FF7E0")]
		public FurnitureAcquireCondTrigger()
		{
		}

		// Token: 0x0400D89C RID: 55452
		[Token(Token = "0x400D89C")]
		[FieldOffset(Offset = "0x20")]
		public string furnitureId;

		// Token: 0x0400D89D RID: 55453
		[Token(Token = "0x400D89D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetDataID;

		// Token: 0x0400D89E RID: 55454
		[Token(Token = "0x400D89E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
