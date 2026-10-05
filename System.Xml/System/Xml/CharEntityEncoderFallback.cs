using System;
using System.Text;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	internal class CharEntityEncoderFallback : EncoderFallback
	{
		// Token: 0x0600001D RID: 29 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		internal CharEntityEncoderFallback()
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x4F74A00", Offset = "0x4F73600", VA = "0x184F74A00", Slot = "4")]
		public override EncoderFallbackBuffer CreateFallbackBuffer()
		{
			return null;
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00002118 File Offset: 0x00000318
		[Token(Token = "0x17000002")]
		public override int MaxCharCount
		{
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x21127B0", Offset = "0x21113B0", VA = "0x1821127B0", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000003 RID: 3
		// (set) Token: 0x06000020 RID: 32 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000003")]
		internal int StartOffset
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x4EF630", Offset = "0x4EE230", VA = "0x1804EF630")]
			set
			{
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x4F74AD0", Offset = "0x4F736D0", VA = "0x184F74AD0")]
		internal void Reset(int[] textContentMarks, int endMarkPos)
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002130 File Offset: 0x00000330
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x4F749A0", Offset = "0x4F735A0", VA = "0x184F749A0")]
		internal bool CanReplaceAt(int index)
		{
			return default(bool);
		}

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x10")]
		private CharEntityEncoderFallbackBuffer fallbackBuffer;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x18")]
		private int[] textContentMarks;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x20")]
		private int endMarkPos;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x24")]
		private int curMarkPos;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x28")]
		private int startOffset;
	}
}
