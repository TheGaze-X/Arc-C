using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.LocalTrack
{
	// Token: 0x0200209D RID: 8349
	[Token(Token = "0x200209D")]
	public class TemplateTrapCondTrigger : PlayerTrackTrigger
	{
		// Token: 0x0600CD8F RID: 52623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CD8F")]
		[Address(RVA = "0x3505140", Offset = "0x3503D40", VA = "0x183505140", Slot = "4")]
		public override string GetDataID()
		{
			return null;
		}

		// Token: 0x0600CD90 RID: 52624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD90")]
		[Address(RVA = "0x35051A0", Offset = "0x3503DA0", VA = "0x1835051A0")]
		public TemplateTrapCondTrigger()
		{
		}

		// Token: 0x0400D8E0 RID: 55520
		[Token(Token = "0x400D8E0")]
		[FieldOffset(Offset = "0x20")]
		public string domainId;

		// Token: 0x0400D8E1 RID: 55521
		[Token(Token = "0x400D8E1")]
		[FieldOffset(Offset = "0x28")]
		public string trapId;

		// Token: 0x0400D8E2 RID: 55522
		[Token(Token = "0x400D8E2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetDataID;

		// Token: 0x0400D8E3 RID: 55523
		[Token(Token = "0x400D8E3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
