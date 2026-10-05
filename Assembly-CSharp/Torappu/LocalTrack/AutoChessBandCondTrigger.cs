using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.LocalTrack
{
	// Token: 0x0200207B RID: 8315
	[Token(Token = "0x200207B")]
	public class AutoChessBandCondTrigger : PlayerTrackTrigger
	{
		// Token: 0x0600CD24 RID: 52516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CD24")]
		[Address(RVA = "0x34F84D0", Offset = "0x34F70D0", VA = "0x1834F84D0", Slot = "4")]
		public override string GetDataID()
		{
			return null;
		}

		// Token: 0x0600CD25 RID: 52517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD25")]
		[Address(RVA = "0x34F8530", Offset = "0x34F7130", VA = "0x1834F8530")]
		public AutoChessBandCondTrigger()
		{
		}

		// Token: 0x0400D864 RID: 55396
		[Token(Token = "0x400D864")]
		[FieldOffset(Offset = "0x20")]
		public string bandId;

		// Token: 0x0400D865 RID: 55397
		[Token(Token = "0x400D865")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetDataID;

		// Token: 0x0400D866 RID: 55398
		[Token(Token = "0x400D866")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
