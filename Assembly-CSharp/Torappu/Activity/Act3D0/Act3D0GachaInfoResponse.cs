using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x020073D5 RID: 29653
	[Token(Token = "0x20073D5")]
	public class Act3D0GachaInfoResponse
	{
		// Token: 0x06029E37 RID: 171575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E37")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act3D0GachaInfoResponse()
		{
		}

		// Token: 0x0403C08F RID: 245903
		[Token(Token = "0x403C08F")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, Act3D0Data.InfinitePoolPercent> info;
	}
}
