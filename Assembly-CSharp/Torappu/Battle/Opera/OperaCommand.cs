using System;
using Il2CppDummyDll;

namespace Torappu.Battle.Opera
{
	// Token: 0x0200269F RID: 9887
	[Token(Token = "0x200269F")]
	[Serializable]
	public struct OperaCommand
	{
		// Token: 0x04011FE6 RID: 73702
		[Token(Token = "0x4011FE6")]
		[FieldOffset(Offset = "0x0")]
		public string key;

		// Token: 0x04011FE7 RID: 73703
		[Token(Token = "0x4011FE7")]
		[FieldOffset(Offset = "0x8")]
		public OperaNodeArray operaNodes;

		// Token: 0x04011FE8 RID: 73704
		[Token(Token = "0x4011FE8")]
		[FieldOffset(Offset = "0x10")]
		public float duration;
	}
}
