using System;
using Il2CppDummyDll;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000431 RID: 1073
	[Token(Token = "0x2000431")]
	internal sealed class MemberPrimitiveTyped
	{
		// Token: 0x060020AC RID: 8364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020AC")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		internal MemberPrimitiveTyped()
		{
		}

		// Token: 0x060020AD RID: 8365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020AD")]
		[Address(RVA = "0x4B93D10", Offset = "0x4B92910", VA = "0x184B93D10")]
		internal void Set(InternalPrimitiveTypeE primitiveTypeEnum, object value)
		{
		}

		// Token: 0x060020AE RID: 8366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020AE")]
		[Address(RVA = "0x4B9DBF0", Offset = "0x4B9C7F0", VA = "0x184B9DBF0", Slot = "4")]
		public void Write(__BinaryWriter sout)
		{
		}

		// Token: 0x060020AF RID: 8367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020AF")]
		[Address(RVA = "0x4B9DBA0", Offset = "0x4B9C7A0", VA = "0x184B9DBA0", Slot = "5")]
		public void Read(__BinaryParser input)
		{
		}

		// Token: 0x060020B0 RID: 8368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B0")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public void Dump()
		{
		}

		// Token: 0x040011A6 RID: 4518
		[Token(Token = "0x40011A6")]
		[FieldOffset(Offset = "0x10")]
		internal InternalPrimitiveTypeE primitiveTypeEnum;

		// Token: 0x040011A7 RID: 4519
		[Token(Token = "0x40011A7")]
		[FieldOffset(Offset = "0x18")]
		internal object value;
	}
}
