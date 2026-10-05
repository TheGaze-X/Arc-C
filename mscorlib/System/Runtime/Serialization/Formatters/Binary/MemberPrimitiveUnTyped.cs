using System;
using Il2CppDummyDll;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000435 RID: 1077
	[Token(Token = "0x2000435")]
	internal sealed class MemberPrimitiveUnTyped
	{
		// Token: 0x060020C1 RID: 8385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020C1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		internal MemberPrimitiveUnTyped()
		{
		}

		// Token: 0x060020C2 RID: 8386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020C2")]
		[Address(RVA = "0x4B93D10", Offset = "0x4B92910", VA = "0x184B93D10")]
		internal void Set(InternalPrimitiveTypeE typeInformation, object value)
		{
		}

		// Token: 0x060020C3 RID: 8387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020C3")]
		[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
		internal void Set(InternalPrimitiveTypeE typeInformation)
		{
		}

		// Token: 0x060020C4 RID: 8388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020C4")]
		[Address(RVA = "0x4B9DCF0", Offset = "0x4B9C8F0", VA = "0x184B9DCF0", Slot = "4")]
		public void Write(__BinaryWriter sout)
		{
		}

		// Token: 0x060020C5 RID: 8389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020C5")]
		[Address(RVA = "0x4B9DCB0", Offset = "0x4B9C8B0", VA = "0x184B9DCB0", Slot = "5")]
		public void Read(__BinaryParser input)
		{
		}

		// Token: 0x060020C6 RID: 8390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020C6")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public void Dump()
		{
		}

		// Token: 0x040011C0 RID: 4544
		[Token(Token = "0x40011C0")]
		[FieldOffset(Offset = "0x10")]
		internal InternalPrimitiveTypeE typeInformation;

		// Token: 0x040011C1 RID: 4545
		[Token(Token = "0x40011C1")]
		[FieldOffset(Offset = "0x18")]
		internal object value;
	}
}
