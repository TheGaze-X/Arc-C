using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007548 RID: 30024
	[Token(Token = "0x2007548")]
	public class Act24SideEatRequest
	{
		// Token: 0x0602A4CB RID: 173259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A4CB")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act24SideEatRequest()
		{
		}

		// Token: 0x0403CD1C RID: 249116
		[Token(Token = "0x403CD1C")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403CD1D RID: 249117
		[Token(Token = "0x403CD1D")]
		[FieldOffset(Offset = "0x18")]
		public string meal;
	}
}
