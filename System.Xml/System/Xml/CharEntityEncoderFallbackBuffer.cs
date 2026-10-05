using System;
using System.Text;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	internal class CharEntityEncoderFallbackBuffer : EncoderFallbackBuffer
	{
		// Token: 0x06000023 RID: 35 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x4F748F0", Offset = "0x4F734F0", VA = "0x184F748F0")]
		internal CharEntityEncoderFallbackBuffer(CharEntityEncoderFallback parent)
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002148 File Offset: 0x00000348
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x4F74260", Offset = "0x4F72E60", VA = "0x184F74260", Slot = "4")]
		public override bool Fallback(char charUnknown, int index)
		{
			return default(bool);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002160 File Offset: 0x00000360
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x4F74530", Offset = "0x4F73130", VA = "0x184F74530", Slot = "5")]
		public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index)
		{
			return default(bool);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002178 File Offset: 0x00000378
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x4F74860", Offset = "0x4F73460", VA = "0x184F74860", Slot = "6")]
		public override char GetNextChar()
		{
			return '\0';
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002190 File Offset: 0x00000390
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x4F748B0", Offset = "0x4F734B0", VA = "0x184F748B0", Slot = "7")]
		public override bool MovePrevious()
		{
			return default(bool);
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000028 RID: 40 RVA: 0x000021A8 File Offset: 0x000003A8
		[Token(Token = "0x17000004")]
		public override int Remaining
		{
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x4F74970", Offset = "0x4F73570", VA = "0x184F74970", Slot = "8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x4F748D0", Offset = "0x4F734D0", VA = "0x184F748D0", Slot = "9")]
		public override void Reset()
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000021C0 File Offset: 0x000003C0
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x4F748E0", Offset = "0x4F734E0", VA = "0x184F748E0")]
		private int SurrogateCharToUtf32(char highSurrogate, char lowSurrogate)
		{
			return 0;
		}

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x30")]
		private CharEntityEncoderFallback parent;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x38")]
		private string charEntity;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x40")]
		private int charEntityIndex;
	}
}
