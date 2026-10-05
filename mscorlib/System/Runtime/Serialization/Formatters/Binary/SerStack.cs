using System;
using Il2CppDummyDll;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200044A RID: 1098
	[Token(Token = "0x200044A")]
	internal sealed class SerStack
	{
		// Token: 0x060021D1 RID: 8657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021D1")]
		[Address(RVA = "0x4BC58F0", Offset = "0x4BC44F0", VA = "0x184BC58F0")]
		internal SerStack(string stackId)
		{
		}

		// Token: 0x060021D2 RID: 8658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021D2")]
		[Address(RVA = "0x4BC57C0", Offset = "0x4BC43C0", VA = "0x184BC57C0")]
		internal void Push(object obj)
		{
		}

		// Token: 0x060021D3 RID: 8659 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60021D3")]
		[Address(RVA = "0x4BC5750", Offset = "0x4BC4350", VA = "0x184BC5750")]
		internal object Pop()
		{
			return null;
		}

		// Token: 0x060021D4 RID: 8660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021D4")]
		[Address(RVA = "0x4BC5630", Offset = "0x4BC4230", VA = "0x184BC5630")]
		internal void IncreaseCapacity()
		{
		}

		// Token: 0x060021D5 RID: 8661 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60021D5")]
		[Address(RVA = "0x4BC5710", Offset = "0x4BC4310", VA = "0x184BC5710")]
		internal object Peek()
		{
			return null;
		}

		// Token: 0x060021D6 RID: 8662 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60021D6")]
		[Address(RVA = "0x4BC56D0", Offset = "0x4BC42D0", VA = "0x184BC56D0")]
		internal object PeekPeek()
		{
			return null;
		}

		// Token: 0x060021D7 RID: 8663 RVA: 0x00013A10 File Offset: 0x00011C10
		[Token(Token = "0x60021D7")]
		[Address(RVA = "0x4BC56C0", Offset = "0x4BC42C0", VA = "0x184BC56C0")]
		internal bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x040012D4 RID: 4820
		[Token(Token = "0x40012D4")]
		[FieldOffset(Offset = "0x10")]
		internal object[] objects;

		// Token: 0x040012D5 RID: 4821
		[Token(Token = "0x40012D5")]
		[FieldOffset(Offset = "0x18")]
		internal string stackId;

		// Token: 0x040012D6 RID: 4822
		[Token(Token = "0x40012D6")]
		[FieldOffset(Offset = "0x20")]
		internal int top;
	}
}
