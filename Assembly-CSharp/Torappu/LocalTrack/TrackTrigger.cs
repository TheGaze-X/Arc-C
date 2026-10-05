using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.LocalTrack
{
	// Token: 0x02002091 RID: 8337
	[Token(Token = "0x2002091")]
	public abstract class TrackTrigger : IHotfixable
	{
		// Token: 0x0600CD63 RID: 52579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD63")]
		[Address(RVA = "0x3505A30", Offset = "0x3504630", VA = "0x183505A30")]
		protected TrackTrigger()
		{
		}

		// Token: 0x0400D8AB RID: 55467
		[Token(Token = "0x400D8AB")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x0400D8AC RID: 55468
		[Token(Token = "0x400D8AC")]
		[FieldOffset(Offset = "0x18")]
		public string type;

		// Token: 0x0400D8AD RID: 55469
		[Token(Token = "0x400D8AD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
