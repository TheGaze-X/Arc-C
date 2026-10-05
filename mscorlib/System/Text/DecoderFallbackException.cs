using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Text
{
	// Token: 0x0200028C RID: 652
	[Token(Token = "0x200028C")]
	[System.Serializable]
	public sealed class DecoderFallbackException : System.ArgumentException
	{
		// Token: 0x06001562 RID: 5474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001562")]
		[Address(RVA = "0x4ADC430", Offset = "0x4ADB030", VA = "0x184ADC430")]
		public DecoderFallbackException()
		{
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001563")]
		[Address(RVA = "0x4ADC3C0", Offset = "0x4ADAFC0", VA = "0x184ADC3C0")]
		public DecoderFallbackException(string message, byte[] bytesUnknown, int index)
		{
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001564")]
		[Address(RVA = "0x4ADC410", Offset = "0x4ADB010", VA = "0x184ADC410")]
		private DecoderFallbackException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
		{
		}

		// Token: 0x04000BE7 RID: 3047
		[Token(Token = "0x4000BE7")]
		[FieldOffset(Offset = "0x98")]
		private byte[] _bytesUnknown;

		// Token: 0x04000BE8 RID: 3048
		[Token(Token = "0x4000BE8")]
		[FieldOffset(Offset = "0xA0")]
		private int _index;
	}
}
