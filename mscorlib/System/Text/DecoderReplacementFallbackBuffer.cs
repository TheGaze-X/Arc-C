using System;
using Il2CppDummyDll;

namespace System.Text
{
	// Token: 0x02000291 RID: 657
	[Token(Token = "0x2000291")]
	public sealed class DecoderReplacementFallbackBuffer : DecoderFallbackBuffer
	{
		// Token: 0x0600158A RID: 5514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600158A")]
		[Address(RVA = "0x4AF5B20", Offset = "0x4AF4720", VA = "0x184AF5B20")]
		public DecoderReplacementFallbackBuffer(DecoderReplacementFallback fallback)
		{
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x0000FC60 File Offset: 0x0000DE60
		[Token(Token = "0x600158B")]
		[Address(RVA = "0x4AF5A40", Offset = "0x4AF4640", VA = "0x184AF5A40", Slot = "4")]
		public override bool Fallback(byte[] bytesUnknown, int index)
		{
			return default(bool);
		}

		// Token: 0x0600158C RID: 5516 RVA: 0x0000FC78 File Offset: 0x0000DE78
		[Token(Token = "0x600158C")]
		[Address(RVA = "0x4AF5A90", Offset = "0x4AF4690", VA = "0x184AF5A90", Slot = "5")]
		public override char GetNextChar()
		{
			return '\0';
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x0600158D RID: 5517 RVA: 0x0000FC90 File Offset: 0x0000DE90
		[Token(Token = "0x17000222")]
		public override int Remaining
		{
			[Token(Token = "0x600158D")]
			[Address(RVA = "0x4AF5B70", Offset = "0x4AF4770", VA = "0x184AF5B70", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600158E RID: 5518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600158E")]
		[Address(RVA = "0x4AF5B00", Offset = "0x4AF4700", VA = "0x184AF5B00", Slot = "7")]
		public override void Reset()
		{
		}

		// Token: 0x0600158F RID: 5519 RVA: 0x0000FCA8 File Offset: 0x0000DEA8
		[Token(Token = "0x600158F")]
		[Address(RVA = "0x4AF5AE0", Offset = "0x4AF46E0", VA = "0x184AF5AE0", Slot = "9")]
		internal unsafe override int InternalFallback(byte[] bytes, byte* pBytes)
		{
			return 0;
		}

		// Token: 0x04000BF2 RID: 3058
		[Token(Token = "0x4000BF2")]
		[FieldOffset(Offset = "0x20")]
		private string _strDefault;

		// Token: 0x04000BF3 RID: 3059
		[Token(Token = "0x4000BF3")]
		[FieldOffset(Offset = "0x28")]
		private int _fallbackCount;

		// Token: 0x04000BF4 RID: 3060
		[Token(Token = "0x4000BF4")]
		[FieldOffset(Offset = "0x2C")]
		private int _fallbackIndex;
	}
}
