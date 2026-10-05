using System;
using Il2CppDummyDll;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000436 RID: 1078
	[Token(Token = "0x2000436")]
	internal sealed class MemberReference
	{
		// Token: 0x060020C7 RID: 8391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020C7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		internal MemberReference()
		{
		}

		// Token: 0x060020C8 RID: 8392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020C8")]
		[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
		internal void Set(int idRef)
		{
		}

		// Token: 0x060020C9 RID: 8393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020C9")]
		[Address(RVA = "0x4B9DD20", Offset = "0x4B9C920", VA = "0x184B9DD20", Slot = "4")]
		public void Write(__BinaryWriter sout)
		{
		}

		// Token: 0x060020CA RID: 8394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020CA")]
		[Address(RVA = "0x4B94E20", Offset = "0x4B93A20", VA = "0x184B94E20", Slot = "5")]
		public void Read(__BinaryParser input)
		{
		}

		// Token: 0x060020CB RID: 8395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020CB")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public void Dump()
		{
		}

		// Token: 0x040011C2 RID: 4546
		[Token(Token = "0x40011C2")]
		[FieldOffset(Offset = "0x10")]
		internal int idRef;
	}
}
