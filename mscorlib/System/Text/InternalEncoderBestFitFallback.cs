using System;
using Il2CppDummyDll;

namespace System.Text
{
	// Token: 0x02000293 RID: 659
	[Token(Token = "0x2000293")]
	[System.Serializable]
	internal class InternalEncoderBestFitFallback : EncoderFallback
	{
		// Token: 0x0600159B RID: 5531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600159B")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		internal InternalEncoderBestFitFallback(Encoding encoding)
		{
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600159C")]
		[Address(RVA = "0x4AFAF50", Offset = "0x4AF9B50", VA = "0x184AFAF50", Slot = "4")]
		public override EncoderFallbackBuffer CreateFallbackBuffer()
		{
			return null;
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x0600159D RID: 5533 RVA: 0x0000FD08 File Offset: 0x0000DF08
		[Token(Token = "0x17000226")]
		public override int MaxCharCount
		{
			[Token(Token = "0x600159D")]
			[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x0000FD20 File Offset: 0x0000DF20
		[Token(Token = "0x600159E")]
		[Address(RVA = "0x4AFAFB0", Offset = "0x4AF9BB0", VA = "0x184AFAFB0", Slot = "0")]
		public override bool Equals(object value)
		{
			return default(bool);
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x0000FD38 File Offset: 0x0000DF38
		[Token(Token = "0x600159F")]
		[Address(RVA = "0x4ADF130", Offset = "0x4ADDD30", VA = "0x184ADF130", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000BF7 RID: 3063
		[Token(Token = "0x4000BF7")]
		[FieldOffset(Offset = "0x10")]
		internal Encoding _encoding;

		// Token: 0x04000BF8 RID: 3064
		[Token(Token = "0x4000BF8")]
		[FieldOffset(Offset = "0x18")]
		internal char[] _arrayBestFit;
	}
}
