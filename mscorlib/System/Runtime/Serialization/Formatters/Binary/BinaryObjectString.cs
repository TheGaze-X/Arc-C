using System;
using Il2CppDummyDll;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200042E RID: 1070
	[Token(Token = "0x200042E")]
	internal sealed class BinaryObjectString
	{
		// Token: 0x060020A1 RID: 8353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020A1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		internal BinaryObjectString()
		{
		}

		// Token: 0x060020A2 RID: 8354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020A2")]
		[Address(RVA = "0x4B93D10", Offset = "0x4B92910", VA = "0x184B93D10")]
		internal void Set(int objectId, string value)
		{
		}

		// Token: 0x060020A3 RID: 8355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020A3")]
		[Address(RVA = "0x4B95FB0", Offset = "0x4B94BB0", VA = "0x184B95FB0", Slot = "4")]
		public void Write(__BinaryWriter sout)
		{
		}

		// Token: 0x060020A4 RID: 8356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020A4")]
		[Address(RVA = "0x4B93CC0", Offset = "0x4B928C0", VA = "0x184B93CC0", Slot = "5")]
		public void Read(__BinaryParser input)
		{
		}

		// Token: 0x060020A5 RID: 8357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020A5")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public void Dump()
		{
		}

		// Token: 0x040011A1 RID: 4513
		[Token(Token = "0x40011A1")]
		[FieldOffset(Offset = "0x10")]
		internal int objectId;

		// Token: 0x040011A2 RID: 4514
		[Token(Token = "0x40011A2")]
		[FieldOffset(Offset = "0x18")]
		internal string value;
	}
}
