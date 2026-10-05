using System;
using Il2CppDummyDll;

namespace System.Text
{
	// Token: 0x0200028E RID: 654
	[Token(Token = "0x200028E")]
	public abstract class DecoderFallbackBuffer
	{
		// Token: 0x0600156A RID: 5482
		[Token(Token = "0x600156A")]
		public abstract bool Fallback(byte[] bytesUnknown, int index);

		// Token: 0x0600156B RID: 5483
		[Token(Token = "0x600156B")]
		public abstract char GetNextChar();

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x0600156C RID: 5484
		[Token(Token = "0x1700021D")]
		public abstract int Remaining { [Token(Token = "0x600156C")] get; }

		// Token: 0x0600156D RID: 5485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600156D")]
		[Address(RVA = "0x4ADC150", Offset = "0x4ADAD50", VA = "0x184ADC150", Slot = "7")]
		public virtual void Reset()
		{
		}

		// Token: 0x0600156E RID: 5486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600156E")]
		[Address(RVA = "0x4ADC110", Offset = "0x4ADAD10", VA = "0x184ADC110")]
		internal void InternalReset()
		{
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600156F")]
		[Address(RVA = "0x4ADC100", Offset = "0x4ADAD00", VA = "0x184ADC100")]
		internal unsafe void InternalInitialize(byte* byteStart, char* charEnd)
		{
		}

		// Token: 0x06001570 RID: 5488 RVA: 0x0000FB28 File Offset: 0x0000DD28
		[Token(Token = "0x6001570")]
		[Address(RVA = "0x4ADBEA0", Offset = "0x4ADAAA0", VA = "0x184ADBEA0", Slot = "8")]
		internal unsafe virtual bool InternalFallback(byte[] bytes, byte* pBytes, ref char* chars)
		{
			return default(bool);
		}

		// Token: 0x06001571 RID: 5489 RVA: 0x0000FB40 File Offset: 0x0000DD40
		[Token(Token = "0x6001571")]
		[Address(RVA = "0x4ADBC70", Offset = "0x4ADA870", VA = "0x184ADBC70", Slot = "9")]
		internal unsafe virtual int InternalFallback(byte[] bytes, byte* pBytes)
		{
			return 0;
		}

		// Token: 0x06001572 RID: 5490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001572")]
		[Address(RVA = "0x4ADC1A0", Offset = "0x4ADADA0", VA = "0x184ADC1A0")]
		internal void ThrowLastBytesRecursive(byte[] bytesUnknown)
		{
		}

		// Token: 0x06001573 RID: 5491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001573")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected DecoderFallbackBuffer()
		{
		}

		// Token: 0x04000BEB RID: 3051
		[Token(Token = "0x4000BEB")]
		[FieldOffset(Offset = "0x10")]
		internal unsafe byte* byteStart;

		// Token: 0x04000BEC RID: 3052
		[Token(Token = "0x4000BEC")]
		[FieldOffset(Offset = "0x18")]
		internal unsafe char* charEnd;
	}
}
