using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Net.NetworkInformation
{
	// Token: 0x0200038E RID: 910
	[Token(Token = "0x200038E")]
	[StructLayout(2)]
	internal struct AlignmentUnion
	{
		// Token: 0x04000EE3 RID: 3811
		[Token(Token = "0x4000EE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong Alignment;

		// Token: 0x04000EE4 RID: 3812
		[Token(Token = "0x4000EE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int Length;

		// Token: 0x04000EE5 RID: 3813
		[Token(Token = "0x4000EE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int IfIndex;
	}
}
