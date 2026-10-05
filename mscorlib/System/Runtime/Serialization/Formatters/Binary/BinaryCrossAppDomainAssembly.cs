using System;
using Il2CppDummyDll;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200042A RID: 1066
	[Token(Token = "0x200042A")]
	internal sealed class BinaryCrossAppDomainAssembly
	{
		// Token: 0x06002092 RID: 8338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002092")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		internal BinaryCrossAppDomainAssembly()
		{
		}

		// Token: 0x06002093 RID: 8339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002093")]
		[Address(RVA = "0x4B94DE0", Offset = "0x4B939E0", VA = "0x184B94DE0", Slot = "4")]
		public void Read(__BinaryParser input)
		{
		}

		// Token: 0x06002094 RID: 8340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002094")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public void Dump()
		{
		}

		// Token: 0x0400118E RID: 4494
		[Token(Token = "0x400118E")]
		[FieldOffset(Offset = "0x10")]
		internal int assemId;

		// Token: 0x0400118F RID: 4495
		[Token(Token = "0x400118F")]
		[FieldOffset(Offset = "0x14")]
		internal int assemblyIndex;
	}
}
