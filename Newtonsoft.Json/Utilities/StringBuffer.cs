using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200006B RID: 107
	[Token(Token = "0x200006B")]
	[Preserve]
	internal struct StringBuffer
	{
		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060003BE RID: 958 RVA: 0x00003600 File Offset: 0x00001800
		// (set) Token: 0x060003BF RID: 959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000B6")]
		public int Position
		{
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x116A510", Offset = "0x1169110", VA = "0x18116A510")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x15EA020", Offset = "0x15E8C20", VA = "0x1815EA020")]
			set
			{
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x00003618 File Offset: 0x00001818
		[Token(Token = "0x170000B7")]
		public bool IsEmpty
		{
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x1E424B0", Offset = "0x1E410B0", VA = "0x181E424B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x4D972D0", Offset = "0x4D95ED0", VA = "0x184D972D0")]
		public StringBuffer(IArrayPool<char> bufferPool, int initalSize)
		{
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x4D97360", Offset = "0x4D95F60", VA = "0x184D97360")]
		private StringBuffer(char[] buffer)
		{
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x4D96F40", Offset = "0x4D95B40", VA = "0x184D96F40")]
		public void Append(IArrayPool<char> bufferPool, char value)
		{
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x4D96FA0", Offset = "0x4D95BA0", VA = "0x184D96FA0")]
		public void Append(IArrayPool<char> bufferPool, char[] buffer, int startIndex, int count)
		{
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x4D970F0", Offset = "0x4D95CF0", VA = "0x184D970F0")]
		public void Clear(IArrayPool<char> bufferPool)
		{
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x4D97180", Offset = "0x4D95D80", VA = "0x184D97180")]
		private void EnsureSize(IArrayPool<char> bufferPool, int appendLength)
		{
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x4D97270", Offset = "0x4D95E70", VA = "0x184D97270", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x4D972A0", Offset = "0x4D95EA0", VA = "0x184D972A0")]
		public string ToString(int start, int length)
		{
			return null;
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B8")]
		public char[] InternalBuffer
		{
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
			get
			{
				return null;
			}
		}

		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x0")]
		private char[] _buffer;

		// Token: 0x040001F9 RID: 505
		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x8")]
		private int _position;
	}
}
