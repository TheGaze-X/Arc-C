using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.LocalTrack
{
	// Token: 0x02002096 RID: 8342
	[Token(Token = "0x2002096")]
	public class NameCardSkinTrigger : PlayerTrackTrigger
	{
		// Token: 0x0600CD75 RID: 52597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CD75")]
		[Address(RVA = "0x35046C0", Offset = "0x35032C0", VA = "0x1835046C0", Slot = "4")]
		public override string GetDataID()
		{
			return null;
		}

		// Token: 0x0600CD76 RID: 52598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD76")]
		[Address(RVA = "0x3504720", Offset = "0x3503320", VA = "0x183504720")]
		public NameCardSkinTrigger()
		{
		}

		// Token: 0x0400D8C0 RID: 55488
		[Token(Token = "0x400D8C0")]
		[FieldOffset(Offset = "0x20")]
		public string nameCardSkinId;

		// Token: 0x0400D8C1 RID: 55489
		[Token(Token = "0x400D8C1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetDataID;

		// Token: 0x0400D8C2 RID: 55490
		[Token(Token = "0x400D8C2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
