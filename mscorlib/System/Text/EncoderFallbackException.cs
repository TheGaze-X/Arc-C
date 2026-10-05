using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Text
{
	// Token: 0x02000297 RID: 663
	[Token(Token = "0x2000297")]
	[System.Serializable]
	public sealed class EncoderFallbackException : System.ArgumentException
	{
		// Token: 0x060015B4 RID: 5556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015B4")]
		[Address(RVA = "0x4AF6590", Offset = "0x4AF5190", VA = "0x184AF6590")]
		public EncoderFallbackException()
		{
		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015B5")]
		[Address(RVA = "0x4AF6810", Offset = "0x4AF5410", VA = "0x184AF6810")]
		internal EncoderFallbackException(string message, char charUnknown, int index)
		{
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015B6")]
		[Address(RVA = "0x4AF65E0", Offset = "0x4AF51E0", VA = "0x184AF65E0")]
		internal EncoderFallbackException(string message, char charUnknownHigh, char charUnknownLow, int index)
		{
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015B7")]
		[Address(RVA = "0x4ADC410", Offset = "0x4ADB010", VA = "0x184ADC410")]
		private EncoderFallbackException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
		{
		}

		// Token: 0x04000BFE RID: 3070
		[Token(Token = "0x4000BFE")]
		[FieldOffset(Offset = "0x98")]
		private char _charUnknown;

		// Token: 0x04000BFF RID: 3071
		[Token(Token = "0x4000BFF")]
		[FieldOffset(Offset = "0x9A")]
		private char _charUnknownHigh;

		// Token: 0x04000C00 RID: 3072
		[Token(Token = "0x4000C00")]
		[FieldOffset(Offset = "0x9C")]
		private char _charUnknownLow;

		// Token: 0x04000C01 RID: 3073
		[Token(Token = "0x4000C01")]
		[FieldOffset(Offset = "0xA0")]
		private int _index;
	}
}
