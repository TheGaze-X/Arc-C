using System;
using Il2CppDummyDll;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006EA6 RID: 28326
	[Token(Token = "0x2006EA6")]
	public class VecBreakV2DefenseFinishBattleResponse : DefaultFinishBattleResponse
	{
		// Token: 0x060284CC RID: 165068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60284CC")]
		[Address(RVA = "0x10D1D40", Offset = "0x10D0940", VA = "0x1810D1D40")]
		public VecBreakV2DefenseFinishBattleResponse()
		{
		}

		// Token: 0x04039463 RID: 234595
		[Token(Token = "0x4039463")]
		[FieldOffset(Offset = "0xA0")]
		public int msBefore;

		// Token: 0x04039464 RID: 234596
		[Token(Token = "0x4039464")]
		[FieldOffset(Offset = "0xA4")]
		public int msAfter;

		// Token: 0x04039465 RID: 234597
		[Token(Token = "0x4039465")]
		[FieldOffset(Offset = "0xA8")]
		public long finTs;
	}
}
