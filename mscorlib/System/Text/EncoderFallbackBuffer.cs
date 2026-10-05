using System;
using Il2CppDummyDll;

namespace System.Text
{
	// Token: 0x02000299 RID: 665
	[Token(Token = "0x2000299")]
	public abstract class EncoderFallbackBuffer
	{
		// Token: 0x060015BD RID: 5565
		[Token(Token = "0x60015BD")]
		public abstract bool Fallback(char charUnknown, int index);

		// Token: 0x060015BE RID: 5566
		[Token(Token = "0x60015BE")]
		public abstract bool Fallback(char charUnknownHigh, char charUnknownLow, int index);

		// Token: 0x060015BF RID: 5567
		[Token(Token = "0x60015BF")]
		public abstract char GetNextChar();

		// Token: 0x060015C0 RID: 5568
		[Token(Token = "0x60015C0")]
		public abstract bool MovePrevious();

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x060015C1 RID: 5569
		[Token(Token = "0x1700022E")]
		public abstract int Remaining { [Token(Token = "0x60015C1")] get; }

		// Token: 0x060015C2 RID: 5570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015C2")]
		[Address(RVA = "0x4AF64A0", Offset = "0x4AF50A0", VA = "0x184AF64A0", Slot = "9")]
		public virtual void Reset()
		{
		}

		// Token: 0x060015C3 RID: 5571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015C3")]
		[Address(RVA = "0x4AF6460", Offset = "0x4AF5060", VA = "0x184AF6460")]
		internal void InternalReset()
		{
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015C4")]
		[Address(RVA = "0x4AF6420", Offset = "0x4AF5020", VA = "0x184AF6420")]
		internal unsafe void InternalInitialize(char* charStart, char* charEnd, EncoderNLS encoder, bool setEncoder)
		{
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x0000FEA0 File Offset: 0x0000E0A0
		[Token(Token = "0x60015C5")]
		[Address(RVA = "0x4AF63D0", Offset = "0x4AF4FD0", VA = "0x184AF63D0")]
		internal char InternalGetNextChar()
		{
			return '\0';
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x0000FEB8 File Offset: 0x0000E0B8
		[Token(Token = "0x60015C6")]
		[Address(RVA = "0x4AF6210", Offset = "0x4AF4E10", VA = "0x184AF6210", Slot = "10")]
		internal unsafe virtual bool InternalFallback(char ch, ref char* chars)
		{
			return default(bool);
		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015C7")]
		[Address(RVA = "0x4AF64F0", Offset = "0x4AF50F0", VA = "0x184AF64F0")]
		internal void ThrowLastCharRecursive(int charRecursive)
		{
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015C8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected EncoderFallbackBuffer()
		{
		}

		// Token: 0x04000C04 RID: 3076
		[Token(Token = "0x4000C04")]
		[FieldOffset(Offset = "0x10")]
		internal unsafe char* charStart;

		// Token: 0x04000C05 RID: 3077
		[Token(Token = "0x4000C05")]
		[FieldOffset(Offset = "0x18")]
		internal unsafe char* charEnd;

		// Token: 0x04000C06 RID: 3078
		[Token(Token = "0x4000C06")]
		[FieldOffset(Offset = "0x20")]
		internal EncoderNLS encoder;

		// Token: 0x04000C07 RID: 3079
		[Token(Token = "0x4000C07")]
		[FieldOffset(Offset = "0x28")]
		internal bool setEncoder;

		// Token: 0x04000C08 RID: 3080
		[Token(Token = "0x4000C08")]
		[FieldOffset(Offset = "0x29")]
		internal bool bUsedEncoder;

		// Token: 0x04000C09 RID: 3081
		[Token(Token = "0x4000C09")]
		[FieldOffset(Offset = "0x2A")]
		internal bool bFallingBack;

		// Token: 0x04000C0A RID: 3082
		[Token(Token = "0x4000C0A")]
		[FieldOffset(Offset = "0x2C")]
		internal int iRecursionCount;

		// Token: 0x04000C0B RID: 3083
		[Token(Token = "0x4000C0B")]
		private const int iMaxRecursion = 250;
	}
}
