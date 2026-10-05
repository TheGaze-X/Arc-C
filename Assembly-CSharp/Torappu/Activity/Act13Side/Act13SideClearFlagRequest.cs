using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x020079E1 RID: 31201
	[Token(Token = "0x20079E1")]
	public class Act13SideClearFlagRequest
	{
		// Token: 0x0602BBEC RID: 179180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BBEC")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act13SideClearFlagRequest()
		{
		}

		// Token: 0x0403F495 RID: 259221
		[Token(Token = "0x403F495")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403F496 RID: 259222
		[Token(Token = "0x403F496")]
		[FieldOffset(Offset = "0x18")]
		public string flag;
	}
}
