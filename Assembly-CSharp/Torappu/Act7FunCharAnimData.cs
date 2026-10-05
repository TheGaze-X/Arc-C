using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000EC7 RID: 3783
	[Token(Token = "0x2000EC7")]
	public class Act7FunCharAnimData
	{
		// Token: 0x06006B97 RID: 27543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B97")]
		[Address(RVA = "0x1FF79D0", Offset = "0x1FF65D0", VA = "0x181FF79D0")]
		public Act7FunCharAnimData()
		{
		}

		// Token: 0x04004FF4 RID: 20468
		[Token(Token = "0x4004FF4")]
		[FieldOffset(Offset = "0x10")]
		public string charId;

		// Token: 0x04004FF5 RID: 20469
		[Token(Token = "0x4004FF5")]
		[FieldOffset(Offset = "0x18")]
		public string failAnimId;

		// Token: 0x04004FF6 RID: 20470
		[Token(Token = "0x4004FF6")]
		[FieldOffset(Offset = "0x20")]
		public List<string> normalAnimIds;
	}
}
