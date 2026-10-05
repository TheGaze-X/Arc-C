using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Text
{
	// Token: 0x020002B0 RID: 688
	[Token(Token = "0x20002B0")]
	[System.Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	internal ref struct ValueStringBuilder
	{
		// Token: 0x060016E0 RID: 5856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016E0")]
		[Address(RVA = "0x4B226B0", Offset = "0x4B212B0", VA = "0x184B226B0")]
		public ValueStringBuilder(System.Span<char> initialBuffer)
		{
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x060016E1 RID: 5857 RVA: 0x00010B48 File Offset: 0x0000ED48
		[Token(Token = "0x17000246")]
		public int Length
		{
			[Token(Token = "0x60016E1")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000247 RID: 583
		[Token(Token = "0x17000247")]
		public char this[int index]
		{
			[Token(Token = "0x60016E2")]
			[Address(RVA = "0x4B226C0", Offset = "0x4B212C0", VA = "0x184B226C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060016E3 RID: 5859 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60016E3")]
		[Address(RVA = "0x4B224E0", Offset = "0x4B210E0", VA = "0x184B224E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060016E4 RID: 5860 RVA: 0x00010B60 File Offset: 0x0000ED60
		[Token(Token = "0x60016E4")]
		[Address(RVA = "0x4B225C0", Offset = "0x4B211C0", VA = "0x184B225C0")]
		public bool TryCopyTo(System.Span<char> destination, out int charsWritten)
		{
			return default(bool);
		}

		// Token: 0x060016E5 RID: 5861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016E5")]
		[Address(RVA = "0x4B22180", Offset = "0x4B20D80", VA = "0x184B22180")]
		[MethodImpl(256)]
		public void Append(char c)
		{
		}

		// Token: 0x060016E6 RID: 5862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016E6")]
		[Address(RVA = "0x4B21EF0", Offset = "0x4B20AF0", VA = "0x184B21EF0")]
		[MethodImpl(256)]
		public void Append(string s)
		{
		}

		// Token: 0x060016E7 RID: 5863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016E7")]
		[Address(RVA = "0x4B21BE0", Offset = "0x4B207E0", VA = "0x184B21BE0")]
		private void AppendSlow(string s)
		{
		}

		// Token: 0x060016E8 RID: 5864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016E8")]
		[Address(RVA = "0x4B220A0", Offset = "0x4B20CA0", VA = "0x184B220A0")]
		public void Append(char c, int count)
		{
		}

		// Token: 0x060016E9 RID: 5865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016E9")]
		[Address(RVA = "0x4B21E10", Offset = "0x4B20A10", VA = "0x184B21E10")]
		public unsafe void Append(char* value, int length)
		{
		}

		// Token: 0x060016EA RID: 5866 RVA: 0x00010B78 File Offset: 0x0000ED78
		[Token(Token = "0x60016EA")]
		[Address(RVA = "0x4B21D30", Offset = "0x4B20930", VA = "0x184B21D30")]
		[MethodImpl(256)]
		public System.Span<char> AppendSpan(int length)
		{
			return default(System.Span<char>);
		}

		// Token: 0x060016EB RID: 5867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016EB")]
		[Address(RVA = "0x4B222A0", Offset = "0x4B20EA0", VA = "0x184B222A0")]
		[MethodImpl(8)]
		private void GrowAndAppend(char c)
		{
		}

		// Token: 0x060016EC RID: 5868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016EC")]
		[Address(RVA = "0x4B22310", Offset = "0x4B20F10", VA = "0x184B22310")]
		[MethodImpl(8)]
		private void Grow(int requiredAdditionalCapacity)
		{
		}

		// Token: 0x060016ED RID: 5869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016ED")]
		[Address(RVA = "0x4B221F0", Offset = "0x4B20DF0", VA = "0x184B221F0")]
		[MethodImpl(256)]
		public void Dispose()
		{
		}

		// Token: 0x04000C52 RID: 3154
		[Token(Token = "0x4000C52")]
		[FieldOffset(Offset = "0x0")]
		private char[] _arrayToReturnToPool;

		// Token: 0x04000C53 RID: 3155
		[Token(Token = "0x4000C53")]
		[FieldOffset(Offset = "0x8")]
		private System.Span<char> _chars;

		// Token: 0x04000C54 RID: 3156
		[Token(Token = "0x4000C54")]
		[FieldOffset(Offset = "0x18")]
		private int _pos;
	}
}
