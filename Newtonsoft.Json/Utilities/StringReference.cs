using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000053 RID: 83
	[Token(Token = "0x2000053")]
	[Preserve]
	internal struct StringReference
	{
		// Token: 0x17000093 RID: 147
		[Token(Token = "0x17000093")]
		public char this[int i]
		{
			[Token(Token = "0x6000307")]
			[Address(RVA = "0x4D97560", Offset = "0x4D96160", VA = "0x184D97560")]
			get
			{
				return '\0';
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000308 RID: 776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000094")]
		public char[] Chars
		{
			[Token(Token = "0x6000308")]
			[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000309 RID: 777 RVA: 0x00002E98 File Offset: 0x00001098
		[Token(Token = "0x17000095")]
		public int StartIndex
		{
			[Token(Token = "0x6000309")]
			[Address(RVA = "0x116A510", Offset = "0x1169110", VA = "0x18116A510")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600030A RID: 778 RVA: 0x00002EB0 File Offset: 0x000010B0
		[Token(Token = "0x17000096")]
		public int Length
		{
			[Token(Token = "0x600030A")]
			[Address(RVA = "0x319ED80", Offset = "0x319D980", VA = "0x18319ED80")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600030B")]
		[Address(RVA = "0x32B0C50", Offset = "0x32AF850", VA = "0x1832B0C50")]
		public StringReference(char[] chars, int startIndex, int length)
		{
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030C")]
		[Address(RVA = "0x4D97530", Offset = "0x4D96130", VA = "0x184D97530", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000191 RID: 401
		[Token(Token = "0x4000191")]
		[FieldOffset(Offset = "0x0")]
		private readonly char[] _chars;

		// Token: 0x04000192 RID: 402
		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0x8")]
		private readonly int _startIndex;

		// Token: 0x04000193 RID: 403
		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0xC")]
		private readonly int _length;
	}
}
