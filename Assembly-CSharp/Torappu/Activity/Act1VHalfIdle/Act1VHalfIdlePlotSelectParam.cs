using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007752 RID: 30546
	[Token(Token = "0x2007752")]
	public class Act1VHalfIdlePlotSelectParam
	{
		// Token: 0x0602AE80 RID: 175744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE80")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act1VHalfIdlePlotSelectParam()
		{
		}

		// Token: 0x0403DDF2 RID: 253426
		[Token(Token = "0x403DDF2")]
		[FieldOffset(Offset = "0x10")]
		public string plotId;

		// Token: 0x0403DDF3 RID: 253427
		[Token(Token = "0x403DDF3")]
		[FieldOffset(Offset = "0x18")]
		public Act1VHalfIdlePlotType type;
	}
}
