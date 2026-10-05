using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020077F1 RID: 30705
	[Token(Token = "0x20077F1")]
	public class GachaDialogOutput
	{
		// Token: 0x0602B143 RID: 176451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B143")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public GachaDialogOutput()
		{
		}

		// Token: 0x0403E3E5 RID: 254949
		[Token(Token = "0x403E3E5")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x0403E3E6 RID: 254950
		[Token(Token = "0x403E3E6")]
		[FieldOffset(Offset = "0x18")]
		public string gachaPoolId;

		// Token: 0x0403E3E7 RID: 254951
		[Token(Token = "0x403E3E7")]
		[FieldOffset(Offset = "0x20")]
		public int gachaPoolSortId;

		// Token: 0x0403E3E8 RID: 254952
		[Token(Token = "0x403E3E8")]
		[FieldOffset(Offset = "0x24")]
		public Act1VHalfIdleGachaPoolType gachaPoolType;
	}
}
