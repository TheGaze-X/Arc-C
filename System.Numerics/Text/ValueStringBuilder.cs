using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Text
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	[DefaultMember("Item")]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	internal ref struct ValueStringBuilder
	{
		// Token: 0x06000040 RID: 64 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x4B226B0", Offset = "0x4B212B0", VA = "0x184B226B0")]
		public ValueStringBuilder(Span<char> initialBuffer)
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000041 RID: 65 RVA: 0x000022F8 File Offset: 0x000004F8
		[Token(Token = "0x17000003")]
		public int Length
		{
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002112 File Offset: 0x00000312
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x4F72420", Offset = "0x4F71020", VA = "0x184F72420", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002310 File Offset: 0x00000510
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x4F72500", Offset = "0x4F71100", VA = "0x184F72500")]
		public bool TryCopyTo(Span<char> destination, out int charsWritten)
		{
			return default(bool);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x4F72240", Offset = "0x4F70E40", VA = "0x184F72240")]
		public void Insert(int index, char value, int count)
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x4F71F10", Offset = "0x4F70B10", VA = "0x184F71F10")]
		[MethodImpl(256)]
		public void Append(char c)
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x4F71D80", Offset = "0x4F70980", VA = "0x184F71D80")]
		[MethodImpl(256)]
		public void Append(string s)
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x4F71A70", Offset = "0x4F70670", VA = "0x184F71A70")]
		private void AppendSlow(string s)
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x4F71CA0", Offset = "0x4F708A0", VA = "0x184F71CA0")]
		public void Append(char c, int count)
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x4F71E30", Offset = "0x4F70A30", VA = "0x184F71E30")]
		public unsafe void Append(char* value, int length)
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002328 File Offset: 0x00000528
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x4F71BC0", Offset = "0x4F707C0", VA = "0x184F71BC0")]
		[MethodImpl(256)]
		public Span<char> AppendSpan(int length)
		{
			return default(Span<char>);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x4F72030", Offset = "0x4F70C30", VA = "0x184F72030")]
		[MethodImpl(8)]
		private void GrowAndAppend(char c)
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x4F72070", Offset = "0x4F70C70", VA = "0x184F72070")]
		[MethodImpl(8)]
		private void Grow(int requiredAdditionalCapacity)
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x4F71F80", Offset = "0x4F70B80", VA = "0x184F71F80")]
		[MethodImpl(256)]
		public void Dispose()
		{
		}

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x0")]
		private char[] _arrayToReturnToPool;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x8")]
		private Span<char> _chars;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x18")]
		private int _pos;
	}
}
