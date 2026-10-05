using System;
using Il2CppDummyDll;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000437 RID: 1079
	[Token(Token = "0x2000437")]
	internal sealed class ObjectNull
	{
		// Token: 0x060020CC RID: 8396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020CC")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		internal ObjectNull()
		{
		}

		// Token: 0x060020CD RID: 8397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020CD")]
		[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
		internal void SetNullCount(int nullCount)
		{
		}

		// Token: 0x060020CE RID: 8398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020CE")]
		[Address(RVA = "0x4BA87E0", Offset = "0x4BA73E0", VA = "0x184BA87E0", Slot = "4")]
		public void Write(__BinaryWriter sout)
		{
		}

		// Token: 0x060020CF RID: 8399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020CF")]
		[Address(RVA = "0x4BA8770", Offset = "0x4BA7370", VA = "0x184BA8770")]
		public void Read(__BinaryParser input, BinaryHeaderEnum binaryHeaderEnum)
		{
		}

		// Token: 0x060020D0 RID: 8400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020D0")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public void Dump()
		{
		}

		// Token: 0x040011C3 RID: 4547
		[Token(Token = "0x40011C3")]
		[FieldOffset(Offset = "0x10")]
		internal int nullCount;
	}
}
