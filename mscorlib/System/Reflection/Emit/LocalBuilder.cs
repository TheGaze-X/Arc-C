using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Reflection.Emit
{
	// Token: 0x0200054B RID: 1355
	[Token(Token = "0x200054B")]
	[StructLayout(0)]
	public sealed class LocalBuilder : LocalVariableInfo
	{
		// Token: 0x04001642 RID: 5698
		[Token(Token = "0x4001642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string name;

		// Token: 0x04001643 RID: 5699
		[Token(Token = "0x4001643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal ILGenerator ilgen;

		// Token: 0x04001644 RID: 5700
		[Token(Token = "0x4001644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int startOffset;

		// Token: 0x04001645 RID: 5701
		[Token(Token = "0x4001645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int endOffset;
	}
}
