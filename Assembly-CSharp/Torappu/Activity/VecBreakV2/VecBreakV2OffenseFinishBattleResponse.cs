using System;
using Il2CppDummyDll;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006EA0 RID: 28320
	[Token(Token = "0x2006EA0")]
	public class VecBreakV2OffenseFinishBattleResponse : DefaultFinishBattleResponse
	{
		// Token: 0x060284C0 RID: 165056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60284C0")]
		[Address(RVA = "0x10D1D40", Offset = "0x10D0940", VA = "0x1810D1D40")]
		public VecBreakV2OffenseFinishBattleResponse()
		{
		}

		// Token: 0x04039457 RID: 234583
		[Token(Token = "0x4039457")]
		[FieldOffset(Offset = "0xA0")]
		public int msBefore;

		// Token: 0x04039458 RID: 234584
		[Token(Token = "0x4039458")]
		[FieldOffset(Offset = "0xA4")]
		public int msAfter;

		// Token: 0x04039459 RID: 234585
		[Token(Token = "0x4039459")]
		[FieldOffset(Offset = "0xA8")]
		public long finTs;
	}
}
