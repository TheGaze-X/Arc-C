using System;
using Il2CppDummyDll;

namespace FullInspector.Internal
{
	// Token: 0x02007C82 RID: 31874
	[Token(Token = "0x2007C82")]
	public struct fiEither<TA, TB>
	{
		// Token: 0x17006842 RID: 26690
		// (get) Token: 0x0602C87E RID: 182398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006842")]
		public TA ValueA
		{
			[Token(Token = "0x602C87E")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006843 RID: 26691
		// (get) Token: 0x0602C87F RID: 182399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006843")]
		public TB ValueB
		{
			[Token(Token = "0x602C87F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006844 RID: 26692
		// (get) Token: 0x0602C880 RID: 182400 RVA: 0x000E0910 File Offset: 0x000DEB10
		[Token(Token = "0x17006844")]
		public bool IsA
		{
			[Token(Token = "0x602C880")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17006845 RID: 26693
		// (get) Token: 0x0602C881 RID: 182401 RVA: 0x000E0928 File Offset: 0x000DEB28
		[Token(Token = "0x17006845")]
		public bool IsB
		{
			[Token(Token = "0x602C881")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602C882 RID: 182402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C882")]
		public fiEither(TA valueA)
		{
		}

		// Token: 0x0602C883 RID: 182403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C883")]
		public fiEither(TB valueB)
		{
		}

		// Token: 0x0404036B RID: 263019
		[Token(Token = "0x404036B")]
		[FieldOffset(Offset = "0x0")]
		private TA _valueA;

		// Token: 0x0404036C RID: 263020
		[Token(Token = "0x404036C")]
		[FieldOffset(Offset = "0x0")]
		private TB _valueB;

		// Token: 0x0404036D RID: 263021
		[Token(Token = "0x404036D")]
		[FieldOffset(Offset = "0x0")]
		private bool _hasA;
	}
}
