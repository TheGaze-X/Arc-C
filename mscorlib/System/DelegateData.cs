using System;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020001A2 RID: 418
	[Token(Token = "0x20001A2")]
	internal sealed class DelegateData
	{
		// Token: 0x06000FAE RID: 4014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FAE")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public DelegateData()
		{
		}

		// Token: 0x04000747 RID: 1863
		[Token(Token = "0x4000747")]
		[FieldOffset(Offset = "0x10")]
		public System.Type target_type;

		// Token: 0x04000748 RID: 1864
		[Token(Token = "0x4000748")]
		[FieldOffset(Offset = "0x18")]
		public string method_name;

		// Token: 0x04000749 RID: 1865
		[Token(Token = "0x4000749")]
		[FieldOffset(Offset = "0x20")]
		public bool curried_first_arg;
	}
}
