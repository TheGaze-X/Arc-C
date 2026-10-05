using System;
using Il2CppDummyDll;

namespace System.Text
{
	// Token: 0x02000292 RID: 658
	[Token(Token = "0x2000292")]
	[System.Serializable]
	public abstract class Encoder
	{
		// Token: 0x06001590 RID: 5520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001590")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected Encoder()
		{
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06001591 RID: 5521 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000223")]
		public EncoderFallback Fallback
		{
			[Token(Token = "0x6001591")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06001592 RID: 5522 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000224")]
		public EncoderFallbackBuffer FallbackBuffer
		{
			[Token(Token = "0x6001592")]
			[Address(RVA = "0x4AF8D30", Offset = "0x4AF7930", VA = "0x184AF8D30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06001593 RID: 5523 RVA: 0x0000FCC0 File Offset: 0x0000DEC0
		[Token(Token = "0x17000225")]
		internal bool InternalHasFallbackBuffer
		{
			[Token(Token = "0x6001593")]
			[Address(RVA = "0x142F770", Offset = "0x142E370", VA = "0x18142F770")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001594 RID: 5524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001594")]
		[Address(RVA = "0x4AF8C00", Offset = "0x4AF7800", VA = "0x184AF8C00", Slot = "4")]
		public virtual void Reset()
		{
		}

		// Token: 0x06001595 RID: 5525
		[Token(Token = "0x6001595")]
		public abstract int GetByteCount(char[] chars, int index, int count, bool flush);

		// Token: 0x06001596 RID: 5526 RVA: 0x0000FCD8 File Offset: 0x0000DED8
		[Token(Token = "0x6001596")]
		[Address(RVA = "0x4AF8780", Offset = "0x4AF7380", VA = "0x184AF8780", Slot = "6")]
		[System.CLSCompliant(false)]
		public unsafe virtual int GetByteCount(char* chars, int count, bool flush)
		{
			return 0;
		}

		// Token: 0x06001597 RID: 5527
		[Token(Token = "0x6001597")]
		public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush);

		// Token: 0x06001598 RID: 5528 RVA: 0x0000FCF0 File Offset: 0x0000DEF0
		[Token(Token = "0x6001598")]
		[Address(RVA = "0x4AF8940", Offset = "0x4AF7540", VA = "0x184AF8940", Slot = "8")]
		[System.CLSCompliant(false)]
		public unsafe virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush)
		{
			return 0;
		}

		// Token: 0x06001599 RID: 5529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001599")]
		[Address(RVA = "0x4AF8380", Offset = "0x4AF6F80", VA = "0x184AF8380", Slot = "9")]
		public virtual void Convert(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed)
		{
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600159A")]
		[Address(RVA = "0x4AF8100", Offset = "0x4AF6D00", VA = "0x184AF8100", Slot = "10")]
		[System.CLSCompliant(false)]
		public unsafe virtual void Convert(char* chars, int charCount, byte* bytes, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed)
		{
		}

		// Token: 0x04000BF5 RID: 3061
		[Token(Token = "0x4000BF5")]
		[FieldOffset(Offset = "0x10")]
		internal EncoderFallback _fallback;

		// Token: 0x04000BF6 RID: 3062
		[Token(Token = "0x4000BF6")]
		[FieldOffset(Offset = "0x18")]
		internal EncoderFallbackBuffer _fallbackBuffer;
	}
}
