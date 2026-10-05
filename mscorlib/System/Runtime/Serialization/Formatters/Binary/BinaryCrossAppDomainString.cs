using System;
using Il2CppDummyDll;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200042F RID: 1071
	[Token(Token = "0x200042F")]
	internal sealed class BinaryCrossAppDomainString
	{
		// Token: 0x060020A6 RID: 8358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020A6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		internal BinaryCrossAppDomainString()
		{
		}

		// Token: 0x060020A7 RID: 8359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020A7")]
		[Address(RVA = "0x4B94DE0", Offset = "0x4B939E0", VA = "0x184B94DE0", Slot = "4")]
		public void Read(__BinaryParser input)
		{
		}

		// Token: 0x060020A8 RID: 8360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020A8")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public void Dump()
		{
		}

		// Token: 0x040011A3 RID: 4515
		[Token(Token = "0x40011A3")]
		[FieldOffset(Offset = "0x10")]
		internal int objectId;

		// Token: 0x040011A4 RID: 4516
		[Token(Token = "0x40011A4")]
		[FieldOffset(Offset = "0x14")]
		internal int value;
	}
}
