using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Text
{
	// Token: 0x02000290 RID: 656
	[Token(Token = "0x2000290")]
	[System.Serializable]
	public sealed class DecoderReplacementFallback : DecoderFallback, System.Runtime.Serialization.ISerializable
	{
		// Token: 0x06001581 RID: 5505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001581")]
		[Address(RVA = "0x4ADD6A0", Offset = "0x4ADC2A0", VA = "0x184ADD6A0")]
		public DecoderReplacementFallback()
		{
		}

		// Token: 0x06001582 RID: 5506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001582")]
		[Address(RVA = "0x4ADD6E0", Offset = "0x4ADC2E0", VA = "0x184ADD6E0")]
		internal DecoderReplacementFallback(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06001583 RID: 5507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001583")]
		[Address(RVA = "0x4ADD640", Offset = "0x4ADC240", VA = "0x184ADD640", Slot = "6")]
		private void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06001584 RID: 5508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001584")]
		[Address(RVA = "0x4ADD7A0", Offset = "0x4ADC3A0", VA = "0x184ADD7A0")]
		public DecoderReplacementFallback(string replacement)
		{
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06001585 RID: 5509 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000220")]
		public string DefaultString
		{
			[Token(Token = "0x6001585")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001586")]
		[Address(RVA = "0x4ADD570", Offset = "0x4ADC170", VA = "0x184ADD570", Slot = "4")]
		public override DecoderFallbackBuffer CreateFallbackBuffer()
		{
			return null;
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06001587 RID: 5511 RVA: 0x0000FC18 File Offset: 0x0000DE18
		[Token(Token = "0x17000221")]
		public override int MaxCharCount
		{
			[Token(Token = "0x6001587")]
			[Address(RVA = "0x5BA1B0", Offset = "0x5B8DB0", VA = "0x1805BA1B0", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x0000FC30 File Offset: 0x0000DE30
		[Token(Token = "0x6001588")]
		[Address(RVA = "0x4ADD5D0", Offset = "0x4ADC1D0", VA = "0x184ADD5D0", Slot = "0")]
		public override bool Equals(object value)
		{
			return default(bool);
		}

		// Token: 0x06001589 RID: 5513 RVA: 0x0000FC48 File Offset: 0x0000DE48
		[Token(Token = "0x6001589")]
		[Address(RVA = "0x2824310", Offset = "0x2822F10", VA = "0x182824310", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000BF1 RID: 3057
		[Token(Token = "0x4000BF1")]
		[FieldOffset(Offset = "0x10")]
		private string _strDefault;
	}
}
