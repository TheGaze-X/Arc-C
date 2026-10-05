using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle.Cooperate
{
	// Token: 0x020026E0 RID: 9952
	[Token(Token = "0x20026E0")]
	[Serializable]
	public class NormalGuideStatus
	{
		// Token: 0x0601030C RID: 66316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601030C")]
		[Address(RVA = "0x7ED3B0", Offset = "0x7EBFB0", VA = "0x1807ED3B0")]
		public NormalGuideStatus()
		{
		}

		// Token: 0x04012177 RID: 74103
		[Token(Token = "0x4012177")]
		[FieldOffset(Offset = "0x10")]
		public int fail;

		// Token: 0x04012178 RID: 74104
		[Token(Token = "0x4012178")]
		[FieldOffset(Offset = "0x18")]
		public List<TargetInfo> targets;
	}
}
