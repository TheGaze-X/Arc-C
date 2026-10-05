using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle.Cooperate
{
	// Token: 0x020026DA RID: 9946
	[Token(Token = "0x20026DA")]
	public struct TargetInfo
	{
		// Token: 0x0401215E RID: 74078
		[Token(Token = "0x401215E")]
		[FieldOffset(Offset = "0x0")]
		public bool complete;

		// Token: 0x0401215F RID: 74079
		[Token(Token = "0x401215F")]
		[FieldOffset(Offset = "0x1")]
		public bool isFail;

		// Token: 0x04012160 RID: 74080
		[Token(Token = "0x4012160")]
		[FieldOffset(Offset = "0x8")]
		public List<int> hpReduce;

		// Token: 0x04012161 RID: 74081
		[Token(Token = "0x4012161")]
		[FieldOffset(Offset = "0x10")]
		public List<string> progress;
	}
}
