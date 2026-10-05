using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x020000C3 RID: 195
	[Token(Token = "0x20000C3")]
	internal sealed class BitSet
	{
		// Token: 0x06000801 RID: 2049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000801")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private BitSet()
		{
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000802")]
		[Address(RVA = "0x4FD8190", Offset = "0x4FD6D90", VA = "0x184FD8190")]
		public BitSet(int count)
		{
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000803 RID: 2051 RVA: 0x000046E0 File Offset: 0x000028E0
		[Token(Token = "0x170001F1")]
		public int Count
		{
			[Token(Token = "0x6000803")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001F2 RID: 498
		[Token(Token = "0x170001F2")]
		public bool this[int index]
		{
			[Token(Token = "0x6000804")]
			[Address(RVA = "0x4FD7EC0", Offset = "0x4FD6AC0", VA = "0x184FD7EC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000805")]
		[Address(RVA = "0x4FD7B60", Offset = "0x4FD6760", VA = "0x184FD7B60")]
		public void Clear()
		{
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000806")]
		[Address(RVA = "0x4FD8110", Offset = "0x4FD6D10", VA = "0x184FD8110")]
		public void Set(int index)
		{
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x00004710 File Offset: 0x00002910
		[Token(Token = "0x6000807")]
		[Address(RVA = "0x4FD7EC0", Offset = "0x4FD6AC0", VA = "0x184FD7EC0")]
		public bool Get(int index)
		{
			return default(bool);
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x00004728 File Offset: 0x00002928
		[Token(Token = "0x6000808")]
		[Address(RVA = "0x4FD7FF0", Offset = "0x4FD6BF0", VA = "0x184FD7FF0")]
		public int NextSet(int startFrom)
		{
			return 0;
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000809")]
		[Address(RVA = "0x4FD7A90", Offset = "0x4FD6690", VA = "0x184FD7A90")]
		public void And(BitSet other)
		{
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600080A")]
		[Address(RVA = "0x4FD8080", Offset = "0x4FD6C80", VA = "0x184FD8080")]
		public void Or(BitSet other)
		{
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00004740 File Offset: 0x00002940
		[Token(Token = "0x600080B")]
		[Address(RVA = "0x4FD7E80", Offset = "0x4FD6A80", VA = "0x184FD7E80", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x00004758 File Offset: 0x00002958
		[Token(Token = "0x600080C")]
		[Address(RVA = "0x4FD7D40", Offset = "0x4FD6940", VA = "0x184FD7D40", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600080D")]
		[Address(RVA = "0x4FD7BB0", Offset = "0x4FD67B0", VA = "0x184FD7BB0")]
		public BitSet Clone()
		{
			return null;
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x00004770 File Offset: 0x00002970
		[Token(Token = "0x600080E")]
		[Address(RVA = "0x4FD7F10", Offset = "0x4FD6B10", VA = "0x184FD7F10")]
		public bool Intersects(BitSet other)
		{
			return default(bool);
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x00004788 File Offset: 0x00002988
		[Token(Token = "0x600080F")]
		[Address(RVA = "0x4FD8180", Offset = "0x4FD6D80", VA = "0x184FD8180")]
		private int Subscript(int bitIndex)
		{
			return 0;
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000810")]
		[Address(RVA = "0x4FD7CB0", Offset = "0x4FD68B0", VA = "0x184FD7CB0")]
		private void EnsureLength(int nRequiredLength)
		{
		}

		// Token: 0x04000416 RID: 1046
		[Token(Token = "0x4000416")]
		[FieldOffset(Offset = "0x10")]
		private int count;

		// Token: 0x04000417 RID: 1047
		[Token(Token = "0x4000417")]
		[FieldOffset(Offset = "0x18")]
		private uint[] bits;
	}
}
